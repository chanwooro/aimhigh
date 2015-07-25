namespace ProjectStudy
{
    partial class QnA
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
            this.student = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(57, 80);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(80, 24);
            this.student.TabIndex = 1;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(57, 39);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(81, 26);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // QnA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 174);
            this.Controls.Add(this.student);
            this.Controls.Add(this.staff);
            this.Name = "QnA";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button staff;

    }
}

