namespace FileManager.Forms
{
    partial class SuccessfulForm
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
            this.Successful_label = new System.Windows.Forms.Label();
            this.Successful_pictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Successful_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Successful_label
            // 
            this.Successful_label.AutoSize = true;
            this.Successful_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Successful_label.Location = new System.Drawing.Point(12, 28);
            this.Successful_label.Name = "Successful_label";
            this.Successful_label.Size = new System.Drawing.Size(338, 72);
            this.Successful_label.TabIndex = 0;
            this.Successful_label.Text = "Successful!";
            // 
            // Successful_pictureBox
            // 
            this.Successful_pictureBox.Image = global::FileManager.Properties.Resources.successIco;
            this.Successful_pictureBox.Location = new System.Drawing.Point(387, 3);
            this.Successful_pictureBox.Name = "Successful_pictureBox";
            this.Successful_pictureBox.Size = new System.Drawing.Size(217, 179);
            this.Successful_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Successful_pictureBox.TabIndex = 1;
            this.Successful_pictureBox.TabStop = false;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(28, 135);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ShortcutsEnabled = false;
            this.richTextBox.Size = new System.Drawing.Size(322, 225);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.LightGreen;
            this.Ok_button.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ok_button.Location = new System.Drawing.Point(434, 324);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(129, 36);
            this.Ok_button.TabIndex = 3;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // SuccessfulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 391);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Successful_pictureBox);
            this.Controls.Add(this.Successful_label);
            this.Name = "SuccessfulForm";
            this.Text = "SuccessfulForm";
            this.Load += new System.EventHandler(this.SuccessfulForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Successful_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Successful_label;
        private PictureBox Successful_pictureBox;
        private RichTextBox richTextBox;
        private Button Ok_button;
    }
}