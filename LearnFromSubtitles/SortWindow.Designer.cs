namespace LearnFromSubtitles
{
    partial class SortWindow
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
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonKnown = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonTrash = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(12, 9);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(272, 38);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "word";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKnown
            // 
            this.buttonKnown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonKnown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKnown.Location = new System.Drawing.Point(12, 50);
            this.buttonKnown.Name = "buttonKnown";
            this.buttonKnown.Size = new System.Drawing.Size(133, 39);
            this.buttonKnown.TabIndex = 1;
            this.buttonKnown.Text = "I know this word!";
            this.buttonKnown.UseVisualStyleBackColor = false;
            this.buttonKnown.Click += new System.EventHandler(this.buttonKnown_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNew.Location = new System.Drawing.Point(154, 50);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(130, 39);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "I don\'t know the word.";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonTrash
            // 
            this.buttonTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTrash.Location = new System.Drawing.Point(296, 50);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(133, 39);
            this.buttonTrash.TabIndex = 3;
            this.buttonTrash.Text = "Trash";
            this.buttonTrash.UseVisualStyleBackColor = false;
            this.buttonTrash.Click += new System.EventHandler(this.buttonTrash_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(296, 9);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(133, 38);
            this.labelCounter.TabIndex = 4;
            this.labelCounter.Text = "567";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 101);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.buttonTrash);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonKnown);
            this.Controls.Add(this.labelWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortWindow";
            this.Text = "Sort the word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonKnown;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonTrash;
        private System.Windows.Forms.Label labelCounter;
    }
}