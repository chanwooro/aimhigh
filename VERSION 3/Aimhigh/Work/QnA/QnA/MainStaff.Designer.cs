namespace QnA
{
    partial class MainStaff
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadSubject = new System.Windows.Forms.Button();
            this.listTest = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.deleteButtons = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.removeButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listQuestion = new System.Windows.Forms.ListBox();
            this.contextAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multichoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainViewHtml = new System.Windows.Forms.WebBrowser();
            this.newSubject = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LoadSubject);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.listTest);
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Controls.Add(this.deleteButtons);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 159);
            this.panel1.TabIndex = 1;
            // 
            // LoadSubject
            // 
            this.LoadSubject.Location = new System.Drawing.Point(311, 115);
            this.LoadSubject.Name = "LoadSubject";
            this.LoadSubject.Size = new System.Drawing.Size(191, 33);
            this.LoadSubject.TabIndex = 4;
            this.LoadSubject.Text = "Open Subject";
            this.LoadSubject.UseVisualStyleBackColor = true;
            this.LoadSubject.Click += new System.EventHandler(this.LoadSubject_Click);
            // 
            // listTest
            // 
            this.listTest.Location = new System.Drawing.Point(965, 115);
            this.listTest.Name = "listTest";
            this.listTest.Size = new System.Drawing.Size(191, 33);
            this.listTest.TabIndex = 3;
            this.listTest.Text = "List Test";
            this.listTest.UseVisualStyleBackColor = true;
            this.listTest.Click += new System.EventHandler(this.listTest_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(757, 115);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(191, 33);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Create Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // deleteButtons
            // 
            this.deleteButtons.Location = new System.Drawing.Point(551, 115);
            this.deleteButtons.Name = "deleteButtons";
            this.deleteButtons.Size = new System.Drawing.Size(191, 33);
            this.deleteButtons.TabIndex = 1;
            this.deleteButtons.Text = "Delete";
            this.deleteButtons.UseVisualStyleBackColor = true;
            this.deleteButtons.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Topic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 192);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.newSubject);
            this.splitContainer1.Panel1.Controls.Add(this.removeButton);
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.listQuestion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainViewHtml);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 718);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(175, 56);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(154, 36);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.username.Location = new System.Drawing.Point(25, 14);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(359, 29);
            this.username.TabIndex = 4;
            this.username.Text = "Welcome to Aimhigh QA System";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listQuestion
            // 
            this.listQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listQuestion.ContextMenuStrip = this.contextAdd;
            this.listQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listQuestion.FormattingEnabled = true;
            this.listQuestion.ItemHeight = 18;
            this.listQuestion.Location = new System.Drawing.Point(-1, 100);
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.Size = new System.Drawing.Size(330, 616);
            this.listQuestion.TabIndex = 0;
            this.listQuestion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listbox1_Click);
            this.listQuestion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listQuestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox1_MouseDoubleClick);
            // 
            // contextAdd
            // 
            this.contextAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextAdd.Name = "contextMenuStrip1";
            this.contextAdd.Size = new System.Drawing.Size(104, 48);
            this.contextAdd.Opening += new System.ComponentModel.CancelEventHandler(this.contextAdd_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalQuestionToolStripMenuItem,
            this.multichoiceToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // normalQuestionToolStripMenuItem
            // 
            this.normalQuestionToolStripMenuItem.Name = "normalQuestionToolStripMenuItem";
            this.normalQuestionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.normalQuestionToolStripMenuItem.Text = "Subjective Question";
            this.normalQuestionToolStripMenuItem.Click += new System.EventHandler(this.normalQuestionToolStripMenuItem_Click);
            // 
            // multichoiceToolStripMenuItem
            // 
            this.multichoiceToolStripMenuItem.Name = "multichoiceToolStripMenuItem";
            this.multichoiceToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.multichoiceToolStripMenuItem.Text = "Multichoice";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // mainViewHtml
            // 
            this.mainViewHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainViewHtml.Location = new System.Drawing.Point(0, 0);
            this.mainViewHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainViewHtml.Name = "mainViewHtml";
            this.mainViewHtml.Size = new System.Drawing.Size(903, 716);
            this.mainViewHtml.TabIndex = 1;
            this.mainViewHtml.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainViewHtml_DocumentCompleted);
            // 
            // newSubject
            // 
            this.newSubject.Location = new System.Drawing.Point(212, 18);
            this.newSubject.Name = "newSubject";
            this.newSubject.Size = new System.Drawing.Size(114, 23);
            this.newSubject.TabIndex = 4;
            this.newSubject.Text = "New Subject";
            this.newSubject.UseVisualStyleBackColor = true;
            this.newSubject.Click += new System.EventHandler(this.newSubject_Click);
            // 
            // MainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 922);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physics and Math QnA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button listTest;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button deleteButtons;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Label username;
        public System.Windows.Forms.ListBox listQuestion;
        private System.Windows.Forms.ContextMenuStrip contextAdd;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multichoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.WebBrowser mainViewHtml;
        public System.Windows.Forms.Button LoadSubject;
        public System.Windows.Forms.Button newSubject;

    }
}