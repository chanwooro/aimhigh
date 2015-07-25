namespace ProjectStudy
{
    partial class confirmation
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
            this.confirmMessage = new System.Windows.Forms.Label();
            this.deleteB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmMessage
            // 
            this.confirmMessage.AutoSize = true;
            this.confirmMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.confirmMessage.Location = new System.Drawing.Point(37, 9);
            this.confirmMessage.Name = "confirmMessage";
            this.confirmMessage.Size = new System.Drawing.Size(262, 44);
            this.confirmMessage.TabIndex = 0;
            this.confirmMessage.Text = "This action cannot be reversed.\r\nDo you really want to delete?";
            this.confirmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(14, 73);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(140, 30);
            this.deleteB.TabIndex = 1;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(173, 73);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(140, 30);
            this.cancelB.TabIndex = 2;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 120);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.confirmMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "confirmation";
            this.Text = "Are you sure?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmMessage;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button cancelB;
    }
}