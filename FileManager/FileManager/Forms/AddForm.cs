using FileManager.Interfaces;
using FileManager.Services;

namespace FileManager.Forms
{
    public partial class AddForm : Form
    {
        private string _currentPath;
        private IFileManagerService _fileManagerService = new FileManagerService();
        public AddForm(string currentPath)
        {
            InitializeComponent();
            _currentPath = currentPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fileManagerService.CreateFile(fileName_textBox.Text,fileType_textBox.Text,_currentPath);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
