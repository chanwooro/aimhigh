namespace QnA
{
    partial class TestPerform
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
            this.SuspendLayout();
            // 
            // mainViewHtml
            // 
            this.mainViewHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewHtml.Location = new System.Drawing.Point(0, 0);
            this.mainViewHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainViewHtml.Name = "mainViewHtml";
            this.mainViewHtml.Size = new System.Drawing.Size(1264, 922);
            this.mainViewHtml.TabIndex = 0;
            this.mainViewHtml.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainViewHtml_DocumentCompleted);
            // 
            // TestPerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 922);
            this.Controls.Add(this.mainViewHtml);
            this.Name = "TestPerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainViewHtml;


    }
}