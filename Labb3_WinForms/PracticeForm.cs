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
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
        }

        public WordList practiceWordList;
        private Word word;
        private string correctAnswer;
        bool answered;
        private void PracticeForm_Load(object sender, EventArgs e)
        {           
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            
            Practice();
        }
        private void PracticeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (answered)
                {
                    Practice();
                }
                else
                {
                    answered = true;
                    if (PracticeInput.Text.ToLower() == correctAnswer)
                    {
                        AnswerCheck_Label.Text = "Correct!";
                    }
                    else
                    {
                        AnswerCheck_Label.Text = "Wrong.";
                        CorrectAnswerLabel.Text = $"The correct answer was {correctAnswer}.";
                    }

                    NextWordButton.Show();
                }
               
            }
        }

        private void NextWordButton_Click(object sender, EventArgs e)
        {
            Practice();
        }

        private void Practice()
        {
            answered = false;
            NextWordButton.Hide();
            PracticeInput.Clear();
            AnswerCheck_Label.Text = String.Empty;
            CorrectAnswerLabel.Text = String.Empty;
            try
            {
                word = practiceWordList.GetWordToPractice();
            }
            catch
            {
                Close();
                throw new ArgumentNullException("Please select a list first!");              
            }

            TranslateXtoY_Label.Text = $"Translate '{word.Translations[word.FromLanguage]}' from {practiceWordList.Languages[word.FromLanguage].CapitalizeFirst()} to {practiceWordList.Languages[word.ToLanguage].CapitalizeFirst()}";
            correctAnswer = word.Translations[word.ToLanguage].ToLower();
        }
    }
}
