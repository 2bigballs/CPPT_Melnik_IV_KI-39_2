using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms.VisualStyles;
using FileManager.Forms;
using FileManager.Interfaces;
using FileManager.Models;

namespace FileManager.Services;

public class FileManagerService : IFileManagerService
{
    public List<string> GetWorkDesktop(string folderPath)
    {

        if (folderPath == null)
        {
            MessageBox.Show("Path must be required!");
            return new List<string>();
        }

        List<string> response = Directory.GetFiles(folderPath).ToList();
        response.AddRange(Directory.GetDirectories(folderPath).ToList());

        return response;
    }

    public void CreateFile(string fileName, string fileType, string path)
    {
        string fullFilePathWithoutType = path + "\\" + fileName;
        if (fileType == "" && !Directory.Exists(fullFilePathWithoutType))
        {
            Directory.CreateDirectory(fullFilePathWithoutType);

            string successfulDirectoryText = $"Directory {fileName} successful create!";
            SuccessfulForm modalDirectorySuccessfulForm = new SuccessfulForm(successfulDirectoryText);
            modalDirectorySuccessfulForm.ShowDialog();
            return;
        }

        if (fileType == "" && Directory.Exists(fullFilePathWithoutType))
        {

            string failureDirectoryText = $"Directory {fileName} already exist!";
            FailureForm modalDirectoryFailureForm = new FailureForm(failureDirectoryText);
            modalDirectoryFailureForm.ShowDialog();
            return;
        }

        string fullFilePathWithType = fullFilePathWithoutType + "." + fileType;
        if (File.Exists(fullFilePathWithType))
        {
            string failureFileText = $"File {fileName} already exist!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }

        File.Create(fullFilePathWithType);
        string successfulFileText = $"File {fileName} successful create!";
        SuccessfulForm modalFileSuccessfulForm = new SuccessfulForm(successfulFileText);
        modalFileSuccessfulForm.ShowDialog();


    }

    public void DeleteFile(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        if (File.Exists(filePath))
        {
            File.Delete(filePath);


            
            string successfulFileText = $"File {fileName} successful delete!";
            SuccessfulForm modalFileSuccessfulForm = new SuccessfulForm(successfulFileText);
            modalFileSuccessfulForm.ShowDialog();

            return;
        }
        
        if (Directory.Exists(filePath))
        {
            Directory.Delete(filePath, true);
            string successfulDirectoryText = $"Directory {fileName} successful delete!";
            SuccessfulForm modalDirectorySuccessfulForm = new SuccessfulForm(successfulDirectoryText);
            modalDirectorySuccessfulForm.ShowDialog();
            return;
        }

        if (!File.Exists(filePath))
        {
            string failureFileText = $"File or directory {fileName} cannot delete, don't exist!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }


        string failureText = $"Undefined error, while you try delete file or directory!";
        FailureForm modalFailureForm = new FailureForm(failureText);
        modalFailureForm.ShowDialog();

    }

    public void OpenFile(string filePath)
    {
        Process.Start("explorer.exe", filePath);
    }

    public void RenameFile(string newName, string currentName, string pathDirectory)
    {
        string currentFilePath = Path.Combine(pathDirectory, currentName);
        string newFilePath = Path.Combine(pathDirectory, newName);

        string currentFileName = Path.GetFileName(currentFilePath);
        string newFileName = Path.GetFileName(newFilePath);
        if (!File.Exists(newFilePath) && File.Exists(currentFilePath))
        {
            File.Move(currentFilePath, newFilePath);

            string successfulText = $"File {currentName} successful rename to {newName}!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();

            return;
        }

        if (File.Exists(newFilePath))
        {
            string failureFileText = $"File {newFileName} already exist!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }

        if (!File.Exists(currentFilePath))
        {
            string failureFileText = $"File {currentFileName} which you want rename don't exist!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }

        if (!Directory.Exists(newFilePath) && Directory.Exists(currentFilePath))
        {
            Directory.Move(currentFilePath, newFilePath);

            string successfulText = $"File {currentName} successful rename to {newName}!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();

            return;
        }
        if (Directory.Exists(newFilePath))
        {
            string failureDirectoryText = $"Directory {newFileName} already exist!";
            FailureForm modalDirectoryFailureForm = new FailureForm(failureDirectoryText);
            modalDirectoryFailureForm.ShowDialog();
            return;
        }

        if (!Directory.Exists(currentFilePath))
        {
            string failureDirectoryText = $"Directory {currentFileName} which you want rename don't exist!";
            FailureForm modalDirectoryFailureForm = new FailureForm(failureDirectoryText);
            modalDirectoryFailureForm.ShowDialog();
            return;
        }

        string failureText = $"Undefined error while file or directory rename!";
        FailureForm modalFailureForm = new FailureForm(failureText);
        modalFailureForm.ShowDialog();
    }

    public bool IsPathValid(string path)
    {
        bool isPathRooted = Path.IsPathRooted(path);

        bool doesExist = File.Exists(path) || Directory.Exists(path);

        return isPathRooted && doesExist;
    }

    public FileAttributesCustom GetFileAttributes(string fullFilePath)
    {
        if (File.Exists(fullFilePath))
        {
            FileInfo fileInfo = new FileInfo(fullFilePath);

            var response = new FileAttributesCustom()
            {
                Name = Path.GetFileName(fullFilePath),
                FullPath = fileInfo.FullName,
                Owner = fileInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).Value,
                Size = fileInfo.Length,
                CreationTime = fileInfo.CreationTime,
                LastWriteTime = fileInfo.LastWriteTime,
                LastAccessTime = fileInfo.LastAccessTime,
                FlagAttribute = File.GetAttributes(fullFilePath).ToString(),
            };
            return response;
        }

        if (Directory.Exists(fullFilePath))
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(fullFilePath);

            long size = GetFolderSize(fullFilePath);
            var response = new FileAttributesCustom()
            {
                Name = Path.GetFileName(fullFilePath),
                FullPath = directoryInfo.FullName,
                Owner = directoryInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).Value,
                Size = size,
                CreationTime = directoryInfo.CreationTime,
                LastWriteTime = directoryInfo.LastWriteTime,
                LastAccessTime = directoryInfo.LastAccessTime,
                FlagAttribute = File.GetAttributes(fullFilePath).ToString(),
            };
            return response;
        }


        return new FileAttributesCustom();
    }

    private long GetFolderSize(string folderPath)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
        long size = 0;


        foreach (FileInfo fileInfo in directoryInfo.GetFiles())
        {
            size += fileInfo.Length;
        }


        foreach (DirectoryInfo subDirectoryInfo in directoryInfo.GetDirectories())
        {
            size += GetFolderSize(subDirectoryInfo.FullName);
        }

        return size;
    }

    public void CopyFile(string fromPath, string toPath)
    {
        string fileName = Path.GetFileName(fromPath);
        

        if (File.Exists(fromPath) && !File.Exists(toPath))
        {
            File.Copy(fromPath, toPath, false);

            string successfulText = $"File {fileName} successful copy!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();

            return;
        }
        if (File.Exists(fromPath) && File.Exists(toPath))
        {
            ConfirmCopyForm modalConfirmCopyForm = new ConfirmCopyForm(fromPath, toPath);
            modalConfirmCopyForm.ShowDialog();
            return;
        }
        if (!File.Exists(fromPath))
        {
            string failureFileText = $"File {fileName} not found!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }


        if (Directory.Exists(fromPath) && !Directory.Exists(toPath))
        {
            Directory.CreateDirectory(toPath);
            foreach (string sourcePath in Directory.GetFileSystemEntries(fromPath, "*", SearchOption.AllDirectories))
            {
                string relativePath = sourcePath.Substring(fromPath.Length + 1);
                string destinationPath = Path.Combine(toPath, relativePath);
                if (Directory.Exists(sourcePath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                else
                {
                    File.Copy(sourcePath, destinationPath, false);
                }
            }

            string successfulText = $"Directory {fileName} successful copy!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();

            return;
        }
        if (Directory.Exists(toPath))
        {
            ConfirmCopyForm modalConfirmCopyForm = new ConfirmCopyForm(fromPath, toPath);
            modalConfirmCopyForm.ShowDialog();
            return;
        }
        if (!Directory.Exists(fromPath))
        {
            string failureDirectoryText = $"Directory {fileName} not found!";
            FailureForm modalDirectoryFailureForm = new FailureForm(failureDirectoryText);
            modalDirectoryFailureForm.ShowDialog();
            return;
        }

        string failureText = $"Undefined error, while you try copy file or directory!";
        FailureForm modalFailureForm = new FailureForm(failureText);
        modalFailureForm.ShowDialog();

    }

    public void CutFile(string fromPath, string toPath)
    {
        var fileName = Path.GetFileName(fromPath);
        if (File.Exists(fromPath) && !File.Exists(toPath))
        {
            File.Move(fromPath, toPath, false);

            string successfulText = $"File {fileName} successful cut!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();
            return;
        }
        if (File.Exists(fromPath) && File.Exists(toPath))
        {
            ConfirmCutForm modalConfirmCopyForm = new ConfirmCutForm(fromPath, toPath);
            modalConfirmCopyForm.ShowDialog();
            return;
        }
        if (!File.Exists(fromPath))
        {
            string failureFileText = $"File {fileName} not found!";
            FailureForm modalFileFailureForm = new FailureForm(failureFileText);
            modalFileFailureForm.ShowDialog();
            return;
        }



        if (!Directory.Exists(toPath))
        {
            Directory.CreateDirectory(toPath);
            foreach (string sourcePath in Directory.GetFileSystemEntries(fromPath, "*", SearchOption.AllDirectories))
            {
                string relativePath = sourcePath.Substring(fromPath.Length + 1);
                string destinationPath = Path.Combine(toPath, relativePath);
                if (Directory.Exists(sourcePath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                else
                {
                    File.Move(sourcePath, destinationPath, false);
                }
            }

            DeleteFile(fromPath);
            string successfulText = $"Directory {fileName} successful cut!";
            SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
            modalSuccessfulForm.ShowDialog();
            return;
        }
        if (Directory.Exists(toPath))
        {
            ConfirmCutForm modalConfirmCopyForm = new ConfirmCutForm(fromPath, toPath);
            modalConfirmCopyForm.ShowDialog();
            DeleteFile(fromPath);
            return;
        }
        if (!Directory.Exists(fromPath))
        {
            string failureDirectoryText = $"Directory {fileName} not found!";
            FailureForm modalDirectoryFailureForm = new FailureForm(failureDirectoryText);
            modalDirectoryFailureForm.ShowDialog();
            return;
        }

        string failureText = $"Undefined error, while you try cut file or directory!";
        FailureForm modalFailureForm = new FailureForm(failureText);
        modalFailureForm.ShowDialog();
    }

   
}