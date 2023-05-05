namespace FileManager.Forms
{
    partial class RenameForm
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
            this.CurrentName_label = new System.Windows.Forms.Label();
            this.NewName_label = new System.Windows.Forms.Label();
            this.currentName_textBox = new System.Windows.Forms.TextBox();
            this.NewName_textBox = new System.Windows.Forms.TextBox();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentName_label
            // 
            this.CurrentName_label.AutoSize = true;
            this.CurrentName_label.Location = new System.Drawing.Point(76, 63);
            this.CurrentName_label.Name = "CurrentName_label";
            this.CurrentName_label.Size = new System.Drawing.Size(82, 15);
            this.CurrentName_label.TabIndex = 0;
            this.CurrentName_label.Text = "Current Name";
            // 
            // NewName_label
            // 
            this.NewName_label.AutoSize = true;
            this.NewName_label.Location = new System.Drawing.Point(92, 121);
            this.NewName_label.Name = "NewName_label";
            this.NewName_label.Size = new System.Drawing.Size(66, 15);
            this.NewName_label.TabIndex = 1;
            this.NewName_label.Text = "New Name";
            // 
            // currentName_textBox
            // 
            this.currentName_textBox.Location = new System.Drawing.Point(176, 60);
            this.currentName_textBox.Name = "currentName_textBox";
            this.currentName_textBox.ReadOnly = true;
            this.currentName_textBox.Size = new System.Drawing.Size(129, 23);
            this.currentName_textBox.TabIndex = 2;
            // 
            // NewName_textBox
            // 
            this.NewName_textBox.Location = new System.Drawing.Point(176, 113);
            this.NewName_textBox.Name = "NewName_textBox";
            this.NewName_textBox.Size = new System.Drawing.Size(129, 23);
            this.NewName_textBox.TabIndex = 3;
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(76, 179);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(100, 30);
            this.Ok_button.TabIndex = 8;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(221, 179);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 30);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 272);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.NewName_textBox);
            this.Controls.Add(this.currentName_textBox);
            this.Controls.Add(this.NewName_label);
            this.Controls.Add(this.CurrentName_label);
            this.Name = "RenameForm";
            this.Text = "RenameForm";
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CurrentName_label;
        private Label NewName_label;
        private TextBox currentName_textBox;
        private TextBox NewName_textBox;
        private Button Ok_button;
        private Button Cancel_button;
    }
}