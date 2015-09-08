namespace QnA
{
    partial class newSubQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.createB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.image_1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.variable = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Text";
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(44, 48);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(559, 148);
            this.textBox_1.TabIndex = 6;
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(44, 393);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(126, 30);
            this.createB.TabIndex = 9;
            this.createB.Text = "Create";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(477, 393);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(126, 30);
            this.cancelB.TabIndex = 10;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // image_1
            // 
            this.image_1.AutoSize = true;
            this.image_1.Location = new System.Drawing.Point(148, 216);
            this.image_1.Name = "image_1";
            this.image_1.Size = new System.Drawing.Size(70, 13);
            this.image_1.TabIndex = 12;
            this.image_1.Text = "Add a picture";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(44, 342);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 22);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Variables";
            // 
            // variable
            // 
            this.variable.Location = new System.Drawing.Point(44, 275);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(559, 20);
            this.variable.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemType
            // 
            this.ItemType.FormattingEnabled = true;
            this.ItemType.Items.AddRange(new object[] {
            "Image",
            "Answer Box",
            "Question text"});
            this.ItemType.Location = new System.Drawing.Point(122, 342);
            this.ItemType.Name = "ItemType";
            this.ItemType.Size = new System.Drawing.Size(108, 21);
            this.ItemType.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Questions";
            // 
            // newSubQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(645, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemType);
            this.Controls.Add(this.variable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.image_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.createB);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.label1);
            this.Name = "newSubQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail about question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label image_1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox variable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ItemType;
        private System.Windows.Forms.Label label3;
    }
}