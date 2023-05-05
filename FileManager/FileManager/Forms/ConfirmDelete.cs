using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Interfaces;
using FileManager.Services;

namespace FileManager.Forms
{
    public partial class ConfirmDelete : Form
    {
        private IFileManagerService _fileManagerService;
        private string _filePath;

        public ConfirmDelete(IFileManagerService fileManagerService,string filePath)
        {
            _fileManagerService = fileManagerService;
            _filePath = filePath;
            InitializeComponent();
        }
        private void ConfirmDelete_Load(object sender, EventArgs e)
        {
           
            var fileName = Path.GetFileName(_filePath);
            string text = $"Are you sure, You want delete {fileName}?";
            AddTextIntoTextBox(text);
        }
        private void Ok_button_Click(object sender, EventArgs e)
        {
            _fileManagerService.DeleteFile(_filePath);
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTextIntoTextBox(string text)
        {
            Delete_richTextBox.Text = text;
        }

      
    }
}
