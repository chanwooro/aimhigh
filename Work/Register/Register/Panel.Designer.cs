namespace Register
{
    partial class Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetB = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteB = new System.Windows.Forms.Button();
            this.createB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetB);
            this.panel1.Controls.Add(this.searchB);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deleteB);
            this.panel1.Controls.Add(this.createB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 599);
            this.panel1.TabIndex = 0;
            // 
            // resetB
            // 
            this.resetB.Location = new System.Drawing.Point(106, 62);
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(70, 21);
            this.resetB.TabIndex = 7;
            this.resetB.Text = "Reset";
            this.resetB.UseVisualStyleBackColor = true;
            this.resetB.Click += new System.EventHandler(this.resetB_Click);
            // 
            // searchB
            // 
            this.searchB.Location = new System.Drawing.Point(4, 62);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(70, 21);
            this.searchB.TabIndex = 6;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(3, 154);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(173, 39);
            this.deleteB.TabIndex = 1;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(3, 99);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(173, 39);
            this.createB.TabIndex = 0;
            this.createB.Text = "Create";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(896, 599);
            this.dataGridView1.TabIndex = 1;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 623);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Database";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetB;
        private System.Windows.Forms.Button searchB;
    }
}