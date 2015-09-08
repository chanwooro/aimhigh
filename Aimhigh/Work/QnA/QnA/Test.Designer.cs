namespace QnA
{
    partial class Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionList = new System.Windows.Forms.ListBox();
            this.SelectQuestionName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuestion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loadList = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name";
            // 
            // testName
            // 
            this.testName.Location = new System.Drawing.Point(30, 71);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(279, 20);
            this.testName.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(407, 111);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(284, 21);
            this.subject.TabIndex = 2;
            this.subject.SelectedIndexChanged += new System.EventHandler(this.subject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject Category";
            // 
            // testList
            // 
            this.testList.ContextMenuStrip = this.contextMenuStrip1;
            this.testList.FormattingEnabled = true;
            this.testList.Location = new System.Drawing.Point(30, 104);
            this.testList.Name = "testList";
            this.testList.Size = new System.Drawing.Size(279, 498);
            this.testList.TabIndex = 4;
            this.testList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.testList_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // questionList
            // 
            this.questionList.FormattingEnabled = true;
            this.questionList.Location = new System.Drawing.Point(407, 154);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(284, 420);
            this.questionList.TabIndex = 5;
            this.questionList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.questionList_DoubleClick);
            // 
            // SelectQuestionName
            // 
            this.SelectQuestionName.AutoSize = true;
            this.SelectQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.SelectQuestionName.Location = new System.Drawing.Point(419, 39);
            this.SelectQuestionName.Name = "SelectQuestionName";
            this.SelectQuestionName.Size = new System.Drawing.Size(258, 29);
            this.SelectQuestionName.TabIndex = 6;
            this.SelectQuestionName.Text = "Select Test Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Question";
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(407, 574);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(284, 28);
            this.addQuestion.TabIndex = 8;
            this.addQuestion.Text = "Add";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QnA.Properties.Resources.arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(331, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 43);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(152, 628);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(201, 33);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(386, 628);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(201, 33);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loadList
            // 
            this.loadList.AutoSize = true;
            this.loadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadList.Location = new System.Drawing.Point(247, 49);
            this.loadList.Name = "loadList";
            this.loadList.Size = new System.Drawing.Size(62, 16);
            this.loadList.TabIndex = 12;
            this.loadList.TabStop = true;
            this.loadList.Text = "Load List";
            this.loadList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadList_LinkClicked);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 681);
            this.Controls.Add(this.loadList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectQuestionName);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.testList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox testList;
        private System.Windows.Forms.ListBox questionList;
        private System.Windows.Forms.Label SelectQuestionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.LinkLabel loadList;
    }
}