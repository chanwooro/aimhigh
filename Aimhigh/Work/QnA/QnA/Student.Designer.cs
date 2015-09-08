namespace QnA
{
    partial class Student
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
            this.mainViewHtml = new System.Windows.Forms.WebBrowser();
            this.listQuestion = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.testB = new System.Windows.Forms.Button();
            this.problemB = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViewHtml
            // 
            this.mainViewHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewHtml.Location = new System.Drawing.Point(0, 0);
            this.mainViewHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainViewHtml.Name = "mainViewHtml";
            this.mainViewHtml.Size = new System.Drawing.Size(903, 798);
            this.mainViewHtml.TabIndex = 1;
            this.mainViewHtml.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainViewHtml_DocumentCompleted);
            // 
            // listQuestion
            // 
            this.listQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listQuestion.FormattingEnabled = true;
            this.listQuestion.ItemHeight = 18;
            this.listQuestion.Location = new System.Drawing.Point(0, 92);
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.Size = new System.Drawing.Size(329, 706);
            this.listQuestion.TabIndex = 0;
            this.listQuestion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listbox1_Click);
            this.listQuestion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 119);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.testB);
            this.splitContainer1.Panel1.Controls.Add(this.problemB);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.listQuestion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainViewHtml);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 800);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 3;
            // 
            // testB
            // 
            this.testB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testB.AutoSize = true;
            this.testB.Location = new System.Drawing.Point(167, 3);
            this.testB.Name = "testB";
            this.testB.Size = new System.Drawing.Size(158, 55);
            this.testB.TabIndex = 3;
            this.testB.Text = "Test";
            this.testB.UseVisualStyleBackColor = true;
            this.testB.Click += new System.EventHandler(this.testB_Click);
            // 
            // problemB
            // 
            this.problemB.AutoSize = true;
            this.problemB.Location = new System.Drawing.Point(3, 3);
            this.problemB.Name = "problemB";
            this.problemB.Size = new System.Drawing.Size(158, 55);
            this.problemB.TabIndex = 2;
            this.problemB.Text = "Problem Solving";
            this.problemB.UseVisualStyleBackColor = true;
            this.problemB.Click += new System.EventHandler(this.problemB_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.username.Location = new System.Drawing.Point(12, 87);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 29);
            this.username.TabIndex = 4;
            this.username.Text = "label1";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 922);
            this.Controls.Add(this.username);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Student";
            this.Text = "Physics and Math QnA";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainViewHtml;
        public System.Windows.Forms.ListBox listQuestion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label username;
        private System.Windows.Forms.Button testB;
        private System.Windows.Forms.Button problemB;
    }
}