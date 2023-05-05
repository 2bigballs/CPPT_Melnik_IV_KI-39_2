namespace FileManager.Forms
{
    public partial class ConfirmCutForm : Form
    {
        private string _fromPath;
        private string _toPath;
        public ConfirmCutForm(string fromPath, string toPath)
        {
            InitializeComponent();
            _fromPath = fromPath;
            _toPath = toPath;
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            var fileName= Path.GetFileName(_fromPath);
            string message = $"You want override {fileName} ?";
            richTextBox.Text = message;
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            this.Close();

            var fileName = Path.GetFileName(_fromPath);
            if (File.Exists(_fromPath))
            {
                File.Move(_fromPath, _toPath, true);

                string successfulText = $"File {fileName} successful override and cut!";
                SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
                modalSuccessfulForm.ShowDialog();
                this.Close();
                return;
            }
            if (Directory.Exists(_fromPath))
            {
                Directory.CreateDirectory(_toPath);
                foreach (string sourcePath in Directory.GetFileSystemEntries(_fromPath, "*", SearchOption.AllDirectories))
                {
                    string relativePath = sourcePath.Substring(_fromPath.Length + 1);
                    string destinationPath = Path.Combine(_toPath, relativePath);
                    if (Directory.Exists(sourcePath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }
                    else
                    {
                        File.Move(sourcePath, destinationPath, true);
                    }
                }
                string successfulText = $"Directory {fileName} successful override and cut!";
                SuccessfulForm modalSuccessfulForm = new SuccessfulForm(successfulText);
                modalSuccessfulForm.ShowDialog();
                this.Close();
                return;
            }

            string failureText = $"Undefined error, while you try cut file or directory!";
            FailureForm modalFailureForm = new FailureForm(failureText);
            modalFailureForm.ShowDialog();
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
