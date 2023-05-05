using FileManager.Interfaces;
using FileManager.Services;

namespace FileManager.Forms
{
    public partial class ViewDetails : Form
    {
        private IFileManagerService _fileManagerService = new FileManagerService();
        private string _fullFilePath;
        public ViewDetails(string fullFilePath)
        {
            InitializeComponent();
            _fullFilePath = fullFilePath;
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            var fileAttributes = _fileManagerService.GetFileAttributes(_fullFilePath);
            Name_textBox.Text= fileAttributes.Name;
            FullPath_textBox.Text = fileAttributes.FullPath;
            Owner_textBox.Text= fileAttributes.Owner;
            Size_textBox.Text=$"{fileAttributes.Size} bytes";
            CreationTime_textBox.Text= fileAttributes.CreationTime.ToString();
            LastWriteTime_textBox.Text= fileAttributes.LastWriteTime.ToString();
            LastAccessTime_textBox.Text=fileAttributes.LastAccessTime.ToString();
            Attribute_textBox.Text = fileAttributes.FlagAttribute;
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
