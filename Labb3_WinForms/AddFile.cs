using Labb3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb3
{
    public partial class AddFile : Form
    {
        
        public AddFile()
        {
            InitializeComponent();
        }

        public bool fileCreated;
        List<string> languages = new List<string>();
        public string newFileName;
        
        private void AddFile_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            fileCreated = false;
            AddLanguageInstructions_Label.Text = $"(Press {Keys.Enter.ToString().ToUpper()} to add.)";
        }
           
        private void LanguagesInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrEmpty(LanguagesInput.Text))
                {
                    LanguagesToAdd_List.Items.Add(new ListViewItem(LanguagesInput.Text.CapitalizeFirst()));
                    LanguagesInput.Clear();
                }              

                e.Handled = true;
                e.SuppressKeyPress = true;
                
            }
            else if(e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }          
        }

        private void FileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            languages.Clear();
            foreach (ListViewItem language in LanguagesToAdd_List.Items)
            {
                languages.Add(language.Text);
            }

            bool hasDuplicate = languages.Count != languages.Distinct().Count();

            if (hasDuplicate)
            {
                MessageBox.Show("Language duplicate detected. \nPlease remove the duplicate in to create the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            newFileName = FileNameInput.Text;
            if (String.IsNullOrEmpty(newFileName))
            {
                MessageBox.Show("Missing file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (languages.Count == 0)
            {
                MessageBox.Show("No languages added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (languages.Count == 1)
            {
                MessageBox.Show("Atleast 2 languages required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WordList newWordList = new WordList(newFileName, languages.ToArray());
                newWordList.Save();
                fileCreated = true;
                Close();
            }
        }

        private void LanguagesToAdd_List_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                LanguagesToAdd_List.SelectedItems[0].Remove();
            }
        }

       
    }
}
