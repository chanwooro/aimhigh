namespace QnA
{
    partial class preview
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
            this.previewHTML = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // previewHTML
            // 
            this.previewHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewHTML.Location = new System.Drawing.Point(5, 5);
            this.previewHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewHTML.Name = "previewHTML";
            this.previewHTML.Size = new System.Drawing.Size(1101, 894);
            this.previewHTML.TabIndex = 0;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 899);
            this.Controls.Add(this.previewHTML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser previewHTML;
    }
}