namespace FileManager.Forms
{
    partial class ConfirmDelete
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
            this.Delete_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Warning_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_richTextBox
            // 
            this.Delete_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Delete_richTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_richTextBox.Location = new System.Drawing.Point(31, 136);
            this.Delete_richTextBox.Name = "Delete_richTextBox";
            this.Delete_richTextBox.Size = new System.Drawing.Size(296, 150);
            this.Delete_richTextBox.TabIndex = 5;
            this.Delete_richTextBox.Text = "";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.LightCoral;
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel_button.Location = new System.Drawing.Point(470, 303);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 32);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ok_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ok_button.Location = new System.Drawing.Point(352, 303);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(112, 32);
            this.Ok_button.TabIndex = 3;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Warning_label
            // 
            this.Warning_label.AutoSize = true;
            this.Warning_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Warning_label.Location = new System.Drawing.Point(12, 9);
            this.Warning_label.Name = "Warning_label";
            this.Warning_label.Size = new System.Drawing.Size(331, 89);
            this.Warning_label.TabIndex = 9;
            this.Warning_label.Text = "Warning!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileManager.Properties.Resources.warningIco;
            this.pictureBox1.Location = new System.Drawing.Point(394, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.Warning_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Delete_richTextBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Name = "ConfirmDelete";
            this.Text = "ConfirmDelete";
            this.Load += new System.EventHandler(this.ConfirmDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Delete_richTextBox;
        private Button Cancel_button;
        private Button Ok_button;
        private Label Warning_label;
        private PictureBox pictureBox1;
    }
}