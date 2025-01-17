namespace WordFrequency
{
    partial class WordFrequency
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
            this.components = new System.ComponentModel.Container();
            this.userInput = new System.Windows.Forms.TextBox();
            this.translate = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.wordFreqList = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(12, 12);
            this.userInput.MaxLength = 2048;
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(776, 513);
            this.userInput.TabIndex = 0;
            // 
            // translate
            // 
            this.translate.Location = new System.Drawing.Point(12, 531);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(393, 54);
            this.translate.TabIndex = 1;
            this.translate.Text = "Translate";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorMsg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorMsg.Location = new System.Drawing.Point(437, 548);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 20);
            this.errorMsg.TabIndex = 2;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // wordFreqList
            // 
            this.wordFreqList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Frequency});
            this.wordFreqList.HideSelection = false;
            this.wordFreqList.Location = new System.Drawing.Point(12, 606);
            this.wordFreqList.Name = "wordFreqList";
            this.wordFreqList.Size = new System.Drawing.Size(776, 315);
            this.wordFreqList.TabIndex = 3;
            this.wordFreqList.UseCompatibleStateImageBehavior = false;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 200;
            // 
            // Frequency
            // 
            this.Frequency.Text = "Frequency";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(619, 531);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(169, 54);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // WordFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 933);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.wordFreqList);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.userInput);
            this.Name = "WordFrequency";
            this.Text = "Word Frequency Counter";
            this.Load += new System.EventHandler(this.WordFrequency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView wordFreqList;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Frequency;
        private System.Windows.Forms.Button clear;
    }
}

