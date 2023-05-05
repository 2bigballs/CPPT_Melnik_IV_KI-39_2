namespace FileManager.Forms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileName_textBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.typeFileLabel = new System.Windows.Forms.Label();
            this.fileType_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileName_textBox
            // 
            this.fileName_textBox.Location = new System.Drawing.Point(184, 29);
            this.fileName_textBox.Name = "fileName_textBox";
            this.fileName_textBox.Size = new System.Drawing.Size(140, 23);
            this.fileName_textBox.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(118, 32);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(60, 15);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File Name";
            this.fileNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // typeFileLabel
            // 
            this.typeFileLabel.AutoSize = true;
            this.typeFileLabel.Location = new System.Drawing.Point(118, 77);
            this.typeFileLabel.Name = "typeFileLabel";
            this.typeFileLabel.Size = new System.Drawing.Size(52, 15);
            this.typeFileLabel.TabIndex = 2;
            this.typeFileLabel.Text = "File Type";
            // 
            // fileType_textBox
            // 
            this.fileType_textBox.Location = new System.Drawing.Point(184, 74);
            this.fileType_textBox.Name = "fileType_textBox";
            this.fileType_textBox.Size = new System.Drawing.Size(140, 23);
            this.fileType_textBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 207);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileType_textBox);
            this.Controls.Add(this.typeFileLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileName_textBox);
            this.Name = "AddForm";
            this.Text = "Creating File";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileName_textBox;
        private Label fileNameLabel;
        private Label typeFileLabel;
        private TextBox fileType_textBox;
        private Button button1;
        private Button button2;
    }
}