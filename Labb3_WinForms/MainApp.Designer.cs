namespace Labb3
{
    partial class MainApp
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
            this.CreateNewFile = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListView();
            this.File_Header = new System.Windows.Forms.ColumnHeader();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LoadedListGrid = new System.Windows.Forms.DataGridView();
            this.AddWordsButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewFile
            // 
            this.CreateNewFile.Location = new System.Drawing.Point(36, 375);
            this.CreateNewFile.Name = "CreateNewFile";
            this.CreateNewFile.Size = new System.Drawing.Size(75, 23);
            this.CreateNewFile.TabIndex = 1;
            this.CreateNewFile.Text = "New";
            this.CreateNewFile.UseVisualStyleBackColor = true;
            this.CreateNewFile.Click += new System.EventHandler(this.CreateNewFile_Click);
            // 
            // FileList
            // 
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File_Header});
            this.FileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FileList.Location = new System.Drawing.Point(12, 12);
            this.FileList.MultiSelect = false;
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(124, 348);
            this.FileList.TabIndex = 2;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // File_Header
            // 
            this.File_Header.Text = "Saved Wordlists:";
            this.File_Header.Width = 120;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(36, 404);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LoadedListGrid
            // 
            this.LoadedListGrid.AllowUserToAddRows = false;
            this.LoadedListGrid.AllowUserToDeleteRows = false;
            this.LoadedListGrid.AllowUserToResizeColumns = false;
            this.LoadedListGrid.AllowUserToResizeRows = false;
            this.LoadedListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadedListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadedListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LoadedListGrid.Location = new System.Drawing.Point(176, 12);
            this.LoadedListGrid.Name = "LoadedListGrid";
            this.LoadedListGrid.ReadOnly = true;
            this.LoadedListGrid.RowTemplate.Height = 25;
            this.LoadedListGrid.Size = new System.Drawing.Size(612, 348);
            this.LoadedListGrid.TabIndex = 4;
            this.LoadedListGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoadedListGrid_KeyDown);
            // 
            // AddWordsButton
            // 
            this.AddWordsButton.AutoSize = true;
            this.AddWordsButton.Location = new System.Drawing.Point(629, 373);
            this.AddWordsButton.Name = "AddWordsButton";
            this.AddWordsButton.Size = new System.Drawing.Size(159, 25);
            this.AddWordsButton.TabIndex = 5;
            this.AddWordsButton.Text = "Add Words";
            this.AddWordsButton.UseVisualStyleBackColor = true;
            this.AddWordsButton.Click += new System.EventHandler(this.AddWordsButton_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.Location = new System.Drawing.Point(629, 404);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(159, 23);
            this.PracticeButton.TabIndex = 6;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.AddWordsButton);
            this.Controls.Add(this.LoadedListGrid);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.CreateNewFile);
            this.DoubleBuffered = true;
            this.Name = "MainApp";
            this.Text = "Vocabulary Practice";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadedListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CreateNewFile;
        private ListView FileList;
        private ColumnHeader File_Header;
        private Button DeleteButton;
        private DataGridView LoadedListGrid;
        private Button AddWordsButton;
        private Button PracticeButton;
    }
}