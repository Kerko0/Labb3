namespace Labb3
{
    partial class PracticeForm
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
            this.PracticeInput = new System.Windows.Forms.TextBox();
            this.TranslateXtoY_Label = new System.Windows.Forms.Label();
            this.AnswerCheck_Label = new System.Windows.Forms.Label();
            this.NextWordButton = new System.Windows.Forms.Button();
            this.CorrectAnswerLabel = new System.Windows.Forms.Label();
            this.AnswerBox_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PracticeInput
            // 
            this.PracticeInput.Location = new System.Drawing.Point(28, 126);
            this.PracticeInput.Name = "PracticeInput";
            this.PracticeInput.Size = new System.Drawing.Size(100, 23);
            this.PracticeInput.TabIndex = 0;
            this.PracticeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticeInput_KeyDown);
            // 
            // TranslateXtoY_Label
            // 
            this.TranslateXtoY_Label.AutoSize = true;
            this.TranslateXtoY_Label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateXtoY_Label.Location = new System.Drawing.Point(17, 26);
            this.TranslateXtoY_Label.Name = "TranslateXtoY_Label";
            this.TranslateXtoY_Label.Size = new System.Drawing.Size(242, 25);
            this.TranslateXtoY_Label.TabIndex = 1;
            this.TranslateXtoY_Label.Text = "What is {word} in {language}?";
            // 
            // AnswerCheck_Label
            // 
            this.AnswerCheck_Label.AutoSize = true;
            this.AnswerCheck_Label.Location = new System.Drawing.Point(79, 108);
            this.AnswerCheck_Label.Name = "AnswerCheck_Label";
            this.AnswerCheck_Label.Size = new System.Drawing.Size(49, 15);
            this.AnswerCheck_Label.TabIndex = 2;
            this.AnswerCheck_Label.Text = "Correct!";
            // 
            // NextWordButton
            // 
            this.NextWordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextWordButton.AutoSize = true;
            this.NextWordButton.Location = new System.Drawing.Point(184, 124);
            this.NextWordButton.Name = "NextWordButton";
            this.NextWordButton.Size = new System.Drawing.Size(75, 25);
            this.NextWordButton.TabIndex = 3;
            this.NextWordButton.Text = "Next Word";
            this.NextWordButton.UseVisualStyleBackColor = true;
            this.NextWordButton.Click += new System.EventHandler(this.NextWordButton_Click);
            // 
            // CorrectAnswerLabel
            // 
            this.CorrectAnswerLabel.AutoSize = true;
            this.CorrectAnswerLabel.Location = new System.Drawing.Point(28, 79);
            this.CorrectAnswerLabel.Name = "CorrectAnswerLabel";
            this.CorrectAnswerLabel.Size = new System.Drawing.Size(170, 15);
            this.CorrectAnswerLabel.TabIndex = 4;
            this.CorrectAnswerLabel.Text = "The correct answer was {word}.";
            // 
            // AnswerBox_Label
            // 
            this.AnswerBox_Label.AutoSize = true;
            this.AnswerBox_Label.Location = new System.Drawing.Point(28, 108);
            this.AnswerBox_Label.Name = "AnswerBox_Label";
            this.AnswerBox_Label.Size = new System.Drawing.Size(49, 15);
            this.AnswerBox_Label.TabIndex = 5;
            this.AnswerBox_Label.Text = "Answer:";
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.AnswerBox_Label);
            this.Controls.Add(this.CorrectAnswerLabel);
            this.Controls.Add(this.NextWordButton);
            this.Controls.Add(this.AnswerCheck_Label);
            this.Controls.Add(this.TranslateXtoY_Label);
            this.Controls.Add(this.PracticeInput);
            this.Name = "PracticeForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PracticeInput;
        private Label TranslateXtoY_Label;
        private Label AnswerCheck_Label;
        private Button NextWordButton;
        private Label CorrectAnswerLabel;
        private Label AnswerBox_Label;
    }
}