using FileManager.Models;
using System.Runtime.InteropServices;

namespace FileManager.Interfaces;

public interface IFileManagerService
{
    List<string> GetWorkDesktop(string folderPath);
    void CreateFile(string fileName, string fileType, string path);
    void DeleteFile(string filePath);
    void OpenFile(string filePath);
    bool IsPathValid(string path);
    void RenameFile(string newName,string currentName, string pathDirectory);
    FileAttributesCustom GetFileAttributes(string fullFilePath);
    void CopyFile(string fromPath, string toPath);
    void CutFile(string fromPath, string toPath);
}