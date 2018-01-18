namespace LearnFromSubtitles
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortNewWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordList = new System.Windows.Forms.ListBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openAccountToolStripMenuItem
            // 
            this.openAccountToolStripMenuItem.Name = "openAccountToolStripMenuItem";
            this.openAccountToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.wordsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(371, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createToolStripMenuItem.Text = "Create...";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.sortNewWordsToolStripMenuItem,
            this.exportWordsToolStripMenuItem});
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem.Text = "Words";
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openTextFileToolStripMenuItem.Text = "Open text file...";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.openTextFileToolStripMenuItem_Click);
            // 
            // sortNewWordsToolStripMenuItem
            // 
            this.sortNewWordsToolStripMenuItem.Name = "sortNewWordsToolStripMenuItem";
            this.sortNewWordsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sortNewWordsToolStripMenuItem.Text = "Sort new words...";
            this.sortNewWordsToolStripMenuItem.Click += new System.EventHandler(this.sortNewWordsToolStripMenuItem_Click);
            // 
            // exportWordsToolStripMenuItem
            // 
            this.exportWordsToolStripMenuItem.Name = "exportWordsToolStripMenuItem";
            this.exportWordsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exportWordsToolStripMenuItem.Text = "Export words...";
            this.exportWordsToolStripMenuItem.Click += new System.EventHandler(this.exportWordsToolStripMenuItem_Click);
            // 
            // wordList
            // 
            this.wordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordList.FormattingEnabled = true;
            this.wordList.ItemHeight = 20;
            this.wordList.Location = new System.Drawing.Point(0, 24);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(371, 412);
            this.wordList.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 436);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainWindow";
            this.Text = "Learn from subtitles";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem openAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortNewWordsToolStripMenuItem;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.ToolStripMenuItem exportWordsToolStripMenuItem;
    }
}

