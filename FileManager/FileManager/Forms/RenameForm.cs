using FileManager.Interfaces;
using FileManager.Services;

namespace FileManager.Forms
{
    public partial class RenameForm : Form
    {
        private DataGridViewCell _selectedCell;
        private string _currentPath;
        private IFileManagerService _fileManagerService = new FileManagerService();
        public RenameForm(DataGridViewCell selectedCell,string currentPath)
        {
            InitializeComponent();
            _selectedCell = selectedCell;
            _currentPath = currentPath;
        }


        private void RenameForm_Load(object sender, EventArgs e)
        {
            currentName_textBox.Text= _selectedCell.AccessibilityObject.Value;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            _fileManagerService.RenameFile(NewName_textBox.Text, currentName_textBox.Text,_currentPath);
            this.Close();
        }
    }
}
