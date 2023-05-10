using System.Security.Cryptography.X509Certificates;
using FileManager.Extensions;
using FileManager.Interfaces;
using FileManager.Models;
using FileManager.Services;

namespace FileManager.Forms
{
    public partial class FileManager : Form
    {
        private string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private List<string> previousPath = new List<string>();
        private IFileManagerService fileManagerService = new FileManagerService();
        private DataGridViewCell selectedCell;
        private string copyFilePath = String.Empty;
        private string cutFilePath = String.Empty;

        public FileManager()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            Rename_button.Enabled = false;
            Copy_button.Enabled = false;
            Cut_button.Enabled = false;
            Delete_button.Enabled = false;
            ViewDetails_button.Enabled = false;


            List<DriveInfo> allDrives = DriveInfo.GetDrives().ToList();
            List<Action<object, EventArgs>> func = new List<Action<object, EventArgs>>()
            {
                DiscC_button_Click,
                DiscD_button_Click,
                DiscE_button_Click,
                DiscF_button_Click,
            };
            int y = 0;
            int indexFunc = 0;
            foreach (DriveInfo drive in allDrives)
            {
                AddPictureAndButton(drive, y, func[indexFunc]);
                y += 50;
                indexFunc++;
            }

            Path_textBox.Text = currentPath;
            var list = fileManagerService.GetWorkDesktop(currentPath);
            List<string> fileType = new List<string>();
            foreach (var item in list)
            {
                fileType.Add(Path.GetExtension(item));
            }
            var listName = list.GetFilesName();
            int i = 0;
            foreach (var item in listName)
            {
                int newWidth = 15;
                int newHeight = 15;

                if (fileType[i] == ".lnk" || fileType[i] == ".exe")
                {
                    i++;
                    Image imageExe = Properties.Resources.exeIco;
                    Image resizedImageExe = new Bitmap(imageExe, newWidth, newHeight);
                    AddRowWithImageAndText(resizedImageExe, item);
                    continue;
                }

                if (fileType[i] == ".docx")
                {
                    i++;
                    Image imageDocx = Properties.Resources.docxIco;
                    Image resizedImageDocx = new Bitmap(imageDocx, newWidth, newHeight);
                    AddRowWithImageAndText(resizedImageDocx, item);
                    continue;
                }

                if (fileType[i] == ".pdf")
                {
                    i++;
                    Image imagePdf = Properties.Resources.pdf;
                    Image resizedImagePdf = new Bitmap(imagePdf, newWidth, newHeight);
                    AddRowWithImageAndText(resizedImagePdf, item);
                    continue;
                }

                if (fileType[i] == ".txt")
                {
                    i++;
                    Image imageTxt = Properties.Resources.txtIco;
                    Image resizedImageTxt = new Bitmap(imageTxt, newWidth, newHeight);
                    AddRowWithImageAndText(resizedImageTxt, item);
                    continue;
                }

                if (fileType[i] == "")
                {
                    i++;
                    Image imageFolder = Properties.Resources.folderIco;
                    Image resizedImageFolder = new Bitmap(imageFolder, newWidth, newHeight);
                    AddRowWithImageAndText(resizedImageFolder, item);
                    continue;
                }

                Image imageUnknownFileIco = Properties.Resources.unknownFileIco;
                Image resizedImageUnknownFileIco = new Bitmap(imageUnknownFileIco, newWidth, newHeight);
                AddRowWithImageAndText(resizedImageUnknownFileIco, item);

                i++;
            }


        }
        public void AddRowWithImageAndText(Image image, string text)
        {

            DataGridViewRow row = new DataGridViewRow();


            DataGridViewImageCell imageCell = new DataGridViewImageCell();

            imageCell.Value = image;
            row.Cells.Add(imageCell);


            DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
            textCell.Value = text;
            row.Cells.Add(textCell);


            dataGridView1.Rows.Add(row);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rename_button.Enabled = true;
                Copy_button.Enabled = true;
                Cut_button.Enabled = true;
                Delete_button.Enabled = true;
                ViewDetails_button.Enabled = true;
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;


            if (rowIndex >= 0 && columnIndex >= 0)
            {

                DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells[columnIndex];
                string fileName = cell.Value.ToString();
                string fullPathFolder = currentPath + "\\" + fileName;
                if (Directory.Exists(fullPathFolder))
                {
                    previousPath.Add(currentPath);
                    currentPath = fullPathFolder;
                    dataGridView1.Rows.Clear();
                    FileManager_Load(sender, e);
                }
                else
                {
                    fileManagerService.OpenFile(fullPathFolder);
                }

            }
        }
        private void AddFile_Click(object sender, EventArgs e)
        {
            AddForm modalAddForm = new AddForm(currentPath);

            modalAddForm.ShowDialog();

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            string fileName = selectedCell.AccessibilityObject.Value;
            //string fullPathFile = currentPath + "\\" + fileName;
            string fullPathFile = Path.Combine(currentPath, fileName);

            ConfirmDelete modalConfirmDelete = new ConfirmDelete(fileManagerService, fullPathFile);

            modalConfirmDelete.ShowDialog();


            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void Path_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!fileManagerService.IsPathValid(Path_textBox.Text))
                {
                    MessageBox.Show("Incorrect Path!");
                    Path_textBox.Text = currentPath;
                    return;
                }
                previousPath.Add(currentPath);
                currentPath = Path_textBox.Text;

                dataGridView1.Rows.Clear();
                FileManager_Load(sender, e);
            }
        }
        private void Rename_button_Click(object sender, EventArgs e)
        {
            RenameForm modalRenameForm = new RenameForm(selectedCell, currentPath);
            modalRenameForm.ShowDialog();

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void ViewDetails_button_Click(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(currentPath, selectedCell.AccessibilityObject.Value);
            ViewDetails modalViewDetails = new ViewDetails(fullPath);
            modalViewDetails.ShowDialog();
        }
        private void Copy_button_Click(object sender, EventArgs e)
        {
            copyFilePath = Path.Combine(currentPath, selectedCell.AccessibilityObject.Value);
            Paste_button.Enabled = true;
        }
        private void Paste_button_Click(object sender, EventArgs e)
        {
            if (copyFilePath != String.Empty)
            {
                var copyDirectory = Path.GetDirectoryName(copyFilePath);
                var copyFilename = Path.GetFileName(copyFilePath);
                if (copyDirectory != currentPath)
                {
                    var destDirectory = Path.Combine(currentPath, copyFilename);
                    fileManagerService.CopyFile(copyFilePath, destDirectory);
                }
                Paste_button.Enabled = false;
                copyFilePath = string.Empty;

                dataGridView1.Rows.Clear();
                FileManager_Load(sender, e);
            }

            if (cutFilePath != String.Empty)
            {
                var cutDirectory = Path.GetDirectoryName(cutFilePath);
                var cutFilename = Path.GetFileName(cutFilePath);
                if (cutDirectory != currentPath)
                {
                    var destDirectory = Path.Combine(currentPath, cutFilename);
                    fileManagerService.CutFile(cutFilePath, destDirectory);
                }
                Paste_button.Enabled = false;
                cutFilePath = string.Empty;

                dataGridView1.Rows.Clear();
                FileManager_Load(sender, e);
            }

        }
        private void Cut_button_Click(object sender, EventArgs e)
        {
            cutFilePath = Path.Combine(currentPath, selectedCell.AccessibilityObject.Value);
            Paste_button.Enabled = true;
        }
        private void DiscC_button_Click(object sender, EventArgs e)
        {
            previousPath.Add(currentPath);
            currentPath = @"C:\";

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void DiscD_button_Click(object sender, EventArgs e)
        {
            previousPath.Add(currentPath);
            currentPath = @"D:\";

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void DiscE_button_Click(object sender, EventArgs e)
        {
            previousPath.Add(currentPath);
            currentPath = @"E:\";

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
        private void DiscF_button_Click(object sender, EventArgs e)
        {
            previousPath.Add(currentPath);
            currentPath = @"E:\";

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }


        public void AddPictureAndButton(DriveInfo driveInfo, int y, Action<object, EventArgs> func)
        {

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(30,30);
            pictureBox.Location = new Point(90, 265 + y);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile("..\\..\\..\\Resources\\discIco.png");
            
            this.Controls.Add(pictureBox);


            Button button = new Button();
            button.Name = $"Disc{driveInfo.Name.Remove(1, 2)}_button";
            button.Click += new System.EventHandler(func);
            button.Location = new Point(130, 260 + y);
            button.Size = new Size(90, 40);
            button.Text = driveInfo.Name;
            this.Controls.Add(button);
        }

        private void About_button_Click(object sender, EventArgs e)
        {
            AboutForm modalAboutForm = new AboutForm();
            modalAboutForm.ShowDialog();
        }

        private void MyPc_button_Click(object sender, EventArgs e)
        {
            previousPath.Add(currentPath);
            currentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }

        private void Back_pictureBox_Click(object sender, EventArgs e)
        {
            if (previousPath.Count > 0)
            {
                currentPath = previousPath.Last();
                previousPath.Remove(previousPath.Last());
                dataGridView1.Rows.Clear();
                FileManager_Load(sender, e);
            }
        }

        private void BackAbove_pictureBox_Click(object sender, EventArgs e)
        {
            var splitList = currentPath.Split('\\').ToList();

            for (int i = 0; i < splitList.Count; i++)
            {
                if (string.IsNullOrEmpty(splitList[i]))
                {
                    splitList.RemoveAt(i);
                }
            }

            if (splitList.Count <= 1)
            { 
                return;
            }

            splitList.RemoveAt(splitList.Count-1);
            previousPath.Add(currentPath);
            currentPath = "";
            foreach (var item in splitList)
            {
                currentPath = Path.Combine(currentPath, item);
            }
            currentPath += "\\";
            dataGridView1.Rows.Clear();
            FileManager_Load(sender, e);
        }
    }
}