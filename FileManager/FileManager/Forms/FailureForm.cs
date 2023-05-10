
namespace FileManager.Forms
{
    public partial class FailureForm : Form
    {
        private string _message;
        public FailureForm(string message)
        {
            _message = message;
            InitializeComponent();
        }
        private void FailuryForm_Load(object sender, EventArgs e)
        {
            richTextBox.Text = _message;
        }
        private void Ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
