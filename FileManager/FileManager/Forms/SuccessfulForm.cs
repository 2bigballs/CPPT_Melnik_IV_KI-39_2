
namespace FileManager.Forms
{
    public partial class SuccessfulForm : Form
    {
        private string _message;
        public SuccessfulForm(string message)
        {
            InitializeComponent();
            _message = message;
        }

        private void SuccessfulForm_Load(object sender, EventArgs e)
        {
            richTextBox.Text = _message;
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
