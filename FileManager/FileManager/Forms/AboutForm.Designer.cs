namespace FileManager.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InfoAboutProd_label = new System.Windows.Forms.Label();
            this.Copyright_label = new System.Windows.Forms.Label();
            this.Rights_label = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileManager.Properties.Resources.fileManagerIco;
            this.pictureBox1.Location = new System.Drawing.Point(28, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // About_label
            // 
            this.About_label.AutoSize = true;
            this.About_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.About_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.About_label.Location = new System.Drawing.Point(265, 84);
            this.About_label.Name = "About_label";
            this.About_label.Size = new System.Drawing.Size(482, 48);
            this.About_label.TabIndex = 1;
            this.About_label.Text = "File Manager By 2bigballs";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(282, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(465, 88);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // InfoAboutProd_label
            // 
            this.InfoAboutProd_label.AutoSize = true;
            this.InfoAboutProd_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoAboutProd_label.Location = new System.Drawing.Point(282, 211);
            this.InfoAboutProd_label.Name = "InfoAboutProd_label";
            this.InfoAboutProd_label.Size = new System.Drawing.Size(198, 20);
            this.InfoAboutProd_label.TabIndex = 3;
            this.InfoAboutProd_label.Text = "Information about product";
            // 
            // Copyright_label
            // 
            this.Copyright_label.AutoSize = true;
            this.Copyright_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Copyright_label.Location = new System.Drawing.Point(28, 430);
            this.Copyright_label.Name = "Copyright_label";
            this.Copyright_label.Size = new System.Drawing.Size(244, 20);
            this.Copyright_label.TabIndex = 4;
            this.Copyright_label.Text = "Copyright © 2022-2023 2bigballs";
            // 
            // Rights_label
            // 
            this.Rights_label.AutoSize = true;
            this.Rights_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rights_label.Location = new System.Drawing.Point(28, 468);
            this.Rights_label.Name = "Rights_label";
            this.Rights_label.Size = new System.Drawing.Size(215, 20);
            this.Rights_label.TabIndex = 5;
            this.Rights_label.Text = "All rights reserved worldwide";
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ok_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ok_button.Location = new System.Drawing.Point(606, 454);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(141, 34);
            this.Ok_button.TabIndex = 6;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Rights_label);
            this.Controls.Add(this.Copyright_label);
            this.Controls.Add(this.InfoAboutProd_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.About_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AboutForm";
            this.Text = "About FM2bb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label About_label;
        private RichTextBox richTextBox1;
        private Label InfoAboutProd_label;
        private Label Copyright_label;
        private Label Rights_label;
        private Button Ok_button;
    }
}