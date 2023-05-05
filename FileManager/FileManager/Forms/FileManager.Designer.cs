namespace FileManager.Forms
{
    partial class FileManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Path_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImageFile = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFile = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Rename_button = new System.Windows.Forms.Button();
            this.ViewDetails_button = new System.Windows.Forms.Button();
            this.Copy_button = new System.Windows.Forms.Button();
            this.Paste_button = new System.Windows.Forms.Button();
            this.Cut_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Path_textBox
            // 
            this.Path_textBox.Location = new System.Drawing.Point(250, 100);
            this.Path_textBox.Name = "Path_textBox";
            this.Path_textBox.Size = new System.Drawing.Size(562, 23);
            this.Path_textBox.TabIndex = 1;
            this.Path_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Path_textBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageFile,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(250, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(562, 326);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ImageFile
            // 
            this.ImageFile.HeaderText = "";
            this.ImageFile.Name = "ImageFile";
            this.ImageFile.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 400;
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(250, 484);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(136, 29);
            this.AddFile.TabIndex = 4;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Enabled = false;
            this.Delete_button.Location = new System.Drawing.Point(392, 484);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(136, 29);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(169, 143);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 6;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Rename_button
            // 
            this.Rename_button.Enabled = false;
            this.Rename_button.Location = new System.Drawing.Point(534, 484);
            this.Rename_button.Name = "Rename_button";
            this.Rename_button.Size = new System.Drawing.Size(136, 29);
            this.Rename_button.TabIndex = 7;
            this.Rename_button.Text = "Rename";
            this.Rename_button.UseVisualStyleBackColor = true;
            this.Rename_button.Click += new System.EventHandler(this.Rename_button_Click);
            // 
            // ViewDetails_button
            // 
            this.ViewDetails_button.Enabled = false;
            this.ViewDetails_button.Location = new System.Drawing.Point(676, 484);
            this.ViewDetails_button.Name = "ViewDetails_button";
            this.ViewDetails_button.Size = new System.Drawing.Size(136, 29);
            this.ViewDetails_button.TabIndex = 8;
            this.ViewDetails_button.Text = "View Details";
            this.ViewDetails_button.UseVisualStyleBackColor = true;
            this.ViewDetails_button.Click += new System.EventHandler(this.ViewDetails_button_Click);
            // 
            // Copy_button
            // 
            this.Copy_button.Enabled = false;
            this.Copy_button.Location = new System.Drawing.Point(250, 529);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Size = new System.Drawing.Size(136, 29);
            this.Copy_button.TabIndex = 9;
            this.Copy_button.Text = "Copy";
            this.Copy_button.UseVisualStyleBackColor = true;
            this.Copy_button.Click += new System.EventHandler(this.Copy_button_Click);
            // 
            // Paste_button
            // 
            this.Paste_button.Enabled = false;
            this.Paste_button.Location = new System.Drawing.Point(392, 529);
            this.Paste_button.Name = "Paste_button";
            this.Paste_button.Size = new System.Drawing.Size(136, 29);
            this.Paste_button.TabIndex = 10;
            this.Paste_button.Text = "Paste";
            this.Paste_button.UseVisualStyleBackColor = true;
            this.Paste_button.Click += new System.EventHandler(this.Paste_button_Click);
            // 
            // Cut_button
            // 
            this.Cut_button.Enabled = false;
            this.Cut_button.Location = new System.Drawing.Point(534, 529);
            this.Cut_button.Name = "Cut_button";
            this.Cut_button.Size = new System.Drawing.Size(136, 29);
            this.Cut_button.TabIndex = 11;
            this.Cut_button.Text = "Cut";
            this.Cut_button.UseVisualStyleBackColor = true;
            this.Cut_button.Click += new System.EventHandler(this.Cut_button_Click);
            // 
            // About_button
            // 
            this.About_button.Location = new System.Drawing.Point(739, 12);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(122, 32);
            this.About_button.TabIndex = 12;
            this.About_button.Text = "About";
            this.About_button.UseVisualStyleBackColor = true;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 613);
            this.Controls.Add(this.About_button);
            this.Controls.Add(this.Cut_button);
            this.Controls.Add(this.Paste_button);
            this.Controls.Add(this.Copy_button);
            this.Controls.Add(this.ViewDetails_button);
            this.Controls.Add(this.Rename_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_textBox);
           
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Path_textBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button AddFile;
        private Button Delete_button;
        private Button Back_button;
        private Button Rename_button;
        private DataGridViewImageColumn ImageFile;
        private DataGridViewTextBoxColumn Name;
        private Button ViewDetails_button;
        private Button Copy_button;
        private Button Paste_button;
        private Button Cut_button;
        private Button About_button;
    }
}