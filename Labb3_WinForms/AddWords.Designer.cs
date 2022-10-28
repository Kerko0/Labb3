namespace Labb3
{
    partial class AddWords
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
            this.AddWordsButton = new System.Windows.Forms.Button();
            this.WordAdded_Label = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWordsButton
            // 
            this.AddWordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWordsButton.AutoSize = true;
            this.AddWordsButton.Location = new System.Drawing.Point(133, 114);
            this.AddWordsButton.Name = "AddWordsButton";
            this.AddWordsButton.Size = new System.Drawing.Size(65, 25);
            this.AddWordsButton.TabIndex = 0;
            this.AddWordsButton.Text = "Add";
            this.AddWordsButton.UseVisualStyleBackColor = true;
            this.AddWordsButton.Click += new System.EventHandler(this.AddWordsButton_Click);
            // 
            // WordAdded_Label
            // 
            this.WordAdded_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WordAdded_Label.AutoSize = true;
            this.WordAdded_Label.Location = new System.Drawing.Point(121, 11);
            this.WordAdded_Label.Name = "WordAdded_Label";
            this.WordAdded_Label.Size = new System.Drawing.Size(77, 15);
            this.WordAdded_Label.TabIndex = 1;
            this.WordAdded_Label.Text = "Word Added!";
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoneButton.AutoSize = true;
            this.DoneButton.Location = new System.Drawing.Point(23, 114);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(65, 25);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(221, 192);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.WordAdded_Label);
            this.Controls.Add(this.AddWordsButton);
            this.Name = "AddWords";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 35);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Words";
            this.Load += new System.EventHandler(this.AddWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddWordsButton;
        private Label WordAdded_Label;
        private Button DoneButton;
    }
}