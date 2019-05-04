namespace Shopping_Application
{
    partial class editProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseImgBT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.applyBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hpCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // browseImgBT
            // 
            this.browseImgBT.Location = new System.Drawing.Point(38, 170);
            this.browseImgBT.Name = "browseImgBT";
            this.browseImgBT.Size = new System.Drawing.Size(75, 23);
            this.browseImgBT.TabIndex = 1;
            this.browseImgBT.Text = "Browse Image";
            this.browseImgBT.UseVisualStyleBackColor = true;
            this.browseImgBT.Click += new System.EventHandler(this.browseImgBT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 86);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(171, 134);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(125, 20);
            this.nameTB.TabIndex = 4;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(302, 134);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(122, 20);
            this.priceTB.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 137);
            this.panel1.TabIndex = 7;
            // 
            // applyBT
            // 
            this.applyBT.Location = new System.Drawing.Point(448, 299);
            this.applyBT.Name = "applyBT";
            this.applyBT.Size = new System.Drawing.Size(75, 23);
            this.applyBT.TabIndex = 8;
            this.applyBT.Text = "Apply";
            this.applyBT.UseVisualStyleBackColor = true;
            this.applyBT.Click += new System.EventHandler(this.applyBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // hpCB
            // 
            this.hpCB.AutoSize = true;
            this.hpCB.Location = new System.Drawing.Point(171, 170);
            this.hpCB.Name = "hpCB";
            this.hpCB.Size = new System.Drawing.Size(92, 17);
            this.hpCB.TabIndex = 12;
            this.hpCB.Text = "Hot Product ?";
            this.hpCB.UseVisualStyleBackColor = true;
            // 
            // editProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 334);
            this.Controls.Add(this.hpCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.browseImgBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "editProduct";
            this.Text = "editProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseImgBT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button applyBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hpCB;
    }
}