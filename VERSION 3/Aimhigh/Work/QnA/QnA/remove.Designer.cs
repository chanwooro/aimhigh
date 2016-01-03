namespace QnA
{
    partial class remove
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
            this.selectedString = new System.Windows.Forms.Label();
            this.deleteB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.chapter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectedString
            // 
            this.selectedString.AutoSize = true;
            this.selectedString.Location = new System.Drawing.Point(80, 9);
            this.selectedString.Name = "selectedString";
            this.selectedString.Size = new System.Drawing.Size(209, 13);
            this.selectedString.TabIndex = 0;
            this.selectedString.Text = "Do you really want to remove this Chapter?";
            this.selectedString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(57, 71);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(91, 29);
            this.deleteB.TabIndex = 1;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(198, 71);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(91, 29);
            this.cancelB.TabIndex = 2;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // chapter
            // 
            this.chapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapter.Location = new System.Drawing.Point(127, 35);
            this.chapter.Name = "chapter";
            this.chapter.Size = new System.Drawing.Size(100, 23);
            this.chapter.TabIndex = 3;
            this.chapter.Text = "label1";
            this.chapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 121);
            this.Controls.Add(this.chapter);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.selectedString);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedString;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label chapter;
    }
}