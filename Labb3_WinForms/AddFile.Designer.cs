namespace Labb3
{
    partial class AddFile
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
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.FileName_Label = new System.Windows.Forms.Label();
            this.Language_Label = new System.Windows.Forms.Label();
            this.LanguagesInput = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.LanguageList_Label = new System.Windows.Forms.Label();
            this.LanguagesToAdd_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.AddLanguageInstructions_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(12, 48);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(100, 23);
            this.FileNameInput.TabIndex = 0;
            this.FileNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileNameInput_KeyDown);
            // 
            // FileName_Label
            // 
            this.FileName_Label.AutoSize = true;
            this.FileName_Label.Location = new System.Drawing.Point(12, 30);
            this.FileName_Label.Name = "FileName_Label";
            this.FileName_Label.Size = new System.Drawing.Size(90, 15);
            this.FileName_Label.TabIndex = 1;
            this.FileName_Label.Text = "New List Name:";
            // 
            // Language_Label
            // 
            this.Language_Label.AutoSize = true;
            this.Language_Label.Location = new System.Drawing.Point(12, 101);
            this.Language_Label.Name = "Language_Label";
            this.Language_Label.Size = new System.Drawing.Size(62, 15);
            this.Language_Label.TabIndex = 2;
            this.Language_Label.Text = "Language:";
            // 
            // LanguagesInput
            // 
            this.LanguagesInput.Location = new System.Drawing.Point(12, 119);
            this.LanguagesInput.Name = "LanguagesInput";
            this.LanguagesInput.Size = new System.Drawing.Size(100, 23);
            this.LanguagesInput.TabIndex = 3;
            this.LanguagesInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LanguagesInput_KeyDown);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(24, 175);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LanguageList_Label
            // 
            this.LanguageList_Label.AutoSize = true;
            this.LanguageList_Label.Location = new System.Drawing.Point(153, 9);
            this.LanguageList_Label.Name = "LanguageList_Label";
            this.LanguageList_Label.Size = new System.Drawing.Size(133, 15);
            this.LanguageList_Label.TabIndex = 6;
            this.LanguageList_Label.Text = "Languages to be added:";
            // 
            // LanguagesToAdd_List
            // 
            this.LanguagesToAdd_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LanguagesToAdd_List.Location = new System.Drawing.Point(153, 30);
            this.LanguagesToAdd_List.Name = "LanguagesToAdd_List";
            this.LanguagesToAdd_List.Size = new System.Drawing.Size(133, 228);
            this.LanguagesToAdd_List.TabIndex = 7;
            this.LanguagesToAdd_List.UseCompatibleStateImageBehavior = false;
            this.LanguagesToAdd_List.View = System.Windows.Forms.View.List;
            this.LanguagesToAdd_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LanguagesToAdd_List_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 100;
            // 
            // AddLanguageInstructions_Label
            // 
            this.AddLanguageInstructions_Label.AutoSize = true;
            this.AddLanguageInstructions_Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLanguageInstructions_Label.Location = new System.Drawing.Point(12, 145);
            this.AddLanguageInstructions_Label.Name = "AddLanguageInstructions_Label";
            this.AddLanguageInstructions_Label.Size = new System.Drawing.Size(150, 13);
            this.AddLanguageInstructions_Label.TabIndex = 8;
            this.AddLanguageInstructions_Label.Text = "Press KEY to add languages.";
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 277);
            this.Controls.Add(this.AddLanguageInstructions_Label);
            this.Controls.Add(this.LanguagesToAdd_List);
            this.Controls.Add(this.LanguageList_Label);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LanguagesInput);
            this.Controls.Add(this.Language_Label);
            this.Controls.Add(this.FileName_Label);
            this.Controls.Add(this.FileNameInput);
            this.MaximizeBox = false;
            this.Name = "AddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New List";
            this.Load += new System.EventHandler(this.AddFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FileNameInput;
        private Label FileName_Label;
        private Label Language_Label;
        private TextBox LanguagesInput;
        private Button CreateButton;
        private Label LanguageList_Label;
        private ListView LanguagesToAdd_List;
        private ColumnHeader columnHeader1;
        private Label AddLanguageInstructions_Label;
    }
}