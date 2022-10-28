using Labb3;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Labb3
{
    public partial class MainApp : Form
    {
        private WordList wordList;
        private Dictionary<string, WordList> wordLists = new Dictionary<string, WordList>();
        private Dictionary<string, DataTable> dataTables = new Dictionary<string, DataTable>();
        private string selectedList;
        public MainApp()
        {
            InitializeComponent();                 
        }

        private void MainApp_Load(object sender, EventArgs e)
        {          
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            HideList();
            DeleteButton.Hide();

            LoadLists();
            LoadDataTables();
            RefreshFileList();         
        }

        
        private void LoadLists()
        {         
            string[] fileNames = WordList.GetLists();
            foreach(string fileName in fileNames)
            {
                wordLists[fileName] = WordList.LoadList(fileName);
            }
            
        }

        private void LoadDataTables()
        {         
            string[] fileNames = WordList.GetLists();

            foreach (string fileName in fileNames)
            {
                dataTables[fileName] = WordListToDataTable(wordLists[fileName]);
            }
        }

        private void RefreshFileList()
        {
            FileList.Items.Clear();
            string[] fileNames = WordList.GetLists();
            
            foreach (string fileName in fileNames)
            {
                ListViewItem item = new ListViewItem(fileName);
                FileList.Items.Add(item);               
            }         
        }


        private void HideList()
        {
            LoadedListGrid.Hide();
            AddWordsButton.Hide();
            PracticeButton.Hide();
        }
        
        private void ShowList()
        {
            LoadedListGrid.Show();
            AddWordsButton.Show();
            PracticeButton.Show();
        }
        private void LoadWordList(string listName)
        {
            GC.Collect();
          
            wordList = wordLists[listName];
            LoadedListGrid.DataSource = dataTables[listName];
            ShowList();

            if (wordList.GetWords().Length > 1)
            {
                PracticeButton.Show();
            }
            else
            {
                PracticeButton.Hide();
            }
        }

        private void ReloadDataTable(string fileName)
        {
            dataTables[fileName] = WordListToDataTable(wordLists[fileName]);
        }

        private DataTable WordListToDataTable(WordList wordList)
        {
            DataTable dataTable = new DataTable();
            foreach(string lang in wordList.Languages)
            {
                dataTable.Columns.Add(lang.CapitalizeFirst(), typeof(string));
            }

            Word[] words = wordList.GetWords();
                  
            foreach (Word word in words)
            {
                DataRow dr = dataTable.NewRow();
                for (int i = 0; i < wordList.Languages.Length; i++)
                {
                    dr[i] = word.Translations[i];
                }

                dataTable.Rows.Add(dr);
            }
                                             
            return dataTable;
        }

        private void CreateNewFile_Click(object sender, EventArgs e)
        {
            AddFile createFileForm = new();
            createFileForm.ShowDialog();
           
            if(createFileForm.fileCreated)
            {
                RefreshFileList();
                LoadLists();
                LoadDataTables();
            }                           
        }


        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FileList.SelectedItems.Count > 0)
            {
                selectedList = FileList.SelectedItems[0].Text;             
                LoadWordList(selectedList);
                DeleteButton.Show();
            }
            else
            {
                DeleteButton.Hide();
                HideList();
            }
                       
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Are you sure you want to delete this list? (No undo)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(warning == DialogResult.Yes)
            {
                WordList.DeleteList(selectedList);
                RefreshFileList();
                wordList = new("", "");
                DeleteButton.Hide();
                HideList();
            }           
        }

        private void AddWordsButton_Click(object sender, EventArgs e)
        {
            AddWords addWords = new();
            try
            {
                addWords.GenerateTextBox(wordList.Languages);
            }
            catch
            {
                throw new ArgumentNullException("No list selected.");           
            }


            foreach(List<string> sList in addWords.translationsToAdd)
            {
                wordList.Add(sList.ToArray());                              
            }
                              
            wordList.Save();
            ReloadDataTable(selectedList);
            LoadWordList(selectedList);
            
        }

        private void LoadedListGrid_KeyDown(object sender, KeyEventArgs e)
        {          
            int selectedLanguage = Array.IndexOf(wordList.Languages, LoadedListGrid.CurrentCell.OwningColumn.Name.ToLower());

            if (e.KeyCode == Keys.Delete)
            {
                wordList.Remove(selectedLanguage,LoadedListGrid.CurrentCell.Value.ToString());
            }

            wordList.Save();
            ReloadDataTable(selectedList);
            LoadWordList(selectedList);               
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.practiceWordList = wordList;
            LoadedListGrid.Hide();
            practiceForm.ShowDialog();
            LoadedListGrid.Show();
        }
    }
}