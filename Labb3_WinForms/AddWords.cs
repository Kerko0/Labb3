using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace Labb3
{
    public partial class AddWords : Form
    {
        public AddWords()
        {
            InitializeComponent();
        }
     
        private void AddWords_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            WordAdded_Label.Hide();
        }

        public void GenerateTextBox(string[] languages)
        {
            int oldYPos = 0;
            Point oldAddButtonLocation = AddWordsButton.Location;
            Point oldDoneButtonLocation = DoneButton.Location;

            for (int i = 0; i < languages.Length; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Clear();           
                textBox.Location = new(100, 30 + oldYPos);
                textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(InputTextBox_KeyDown);
                textBox.TextChanged += new System.EventHandler(InputTextBox_TextChanged);
                Controls.Add(textBox);            
                oldYPos = textBox.Location.Y;
            }

            oldYPos = 0;

            for(int i = 0; i < languages.Length; i++)
            {
                Label label = new Label();
                label.Text = languages[i].CapitalizeFirst() + ":";
                label.Location = new(30, 30 + oldYPos);
                Controls.Add(label);
                oldYPos = label.Location.Y;
            }
            
            AddWordsButton.Location = new(oldAddButtonLocation.X, oldYPos + 30);
            DoneButton.Location = new(oldDoneButtonLocation.X, oldYPos + 30);
            Controls[3].Select();
            ShowDialog();
            
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Control txtBox = sender as TextBox;
            if(txtBox.Text != string.Empty)
            {
                WordAdded_Label.Hide();
            }
            
        }

        public List<List<string>> translationsToAdd = new List<List<string>>();
        private void AddWordsButton_Click(object sender, EventArgs e)
        {
            List<string> translations = new List<string>();        
            foreach(Control c in Controls)
            {
                if (c is TextBox txtBox)
                {
                    translations.Add(txtBox.Text);                          
                }                                           
            }

            foreach(string translation in translations)
            {
                if(translation == string.Empty)
                {
                    MessageBox.Show("Missing translation. Unable to add word", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    continue;
                }
            }

            foreach (Control c in Controls)
            {
                if (c is TextBox txtBox)
                {
                    txtBox.Clear();
                }
            }

            translationsToAdd.Add(translations);
            WordAdded_Label.Show();
            Controls[3].Select();
                       
            
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
