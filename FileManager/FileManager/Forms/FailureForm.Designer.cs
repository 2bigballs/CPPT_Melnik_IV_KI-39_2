namespace FileManager.Forms
{
    partial class FailureForm
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
            this.Ok_button = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Failure_pictureBox = new System.Windows.Forms.PictureBox();
            this.Failure_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Failure_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.LightCoral;
            this.Ok_button.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ok_button.Location = new System.Drawing.Point(434, 331);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(129, 36);
            this.Ok_button.TabIndex = 7;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(28, 142);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ShortcutsEnabled = false;
            this.richTextBox.Size = new System.Drawing.Size(322, 225);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // Failure_pictureBox
            // 
            this.Failure_pictureBox.Image = global::FileManager.Properties.Resources.failureIco;
            this.Failure_pictureBox.Location = new System.Drawing.Point(376, 12);
            this.Failure_pictureBox.Name = "Failure_pictureBox";
            this.Failure_pictureBox.Size = new System.Drawing.Size(217, 179);
            this.Failure_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Failure_pictureBox.TabIndex = 5;
            this.Failure_pictureBox.TabStop = false;
            // 
            // Failure_label
            // 
            this.Failure_label.AutoSize = true;
            this.Failure_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Failure_label.Location = new System.Drawing.Point(28, 33);
            this.Failure_label.Name = "Failure_label";
            this.Failure_label.Size = new System.Drawing.Size(290, 89);
            this.Failure_label.TabIndex = 4;
            this.Failure_label.Text = "Failure!";
            // 
            // FailuryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 391);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Failure_pictureBox);
            this.Controls.Add(this.Failure_label);
            this.Name = "FailuryForm";
            this.Text = "FailuaryForm";
            this.Load += new System.EventHandler(this.FailuryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Failure_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Ok_button;
        private RichTextBox richTextBox;
        private PictureBox Failure_pictureBox;
        private Label Failure_label;
    }
}