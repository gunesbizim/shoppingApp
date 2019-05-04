namespace Shopping_Application
{
    partial class adminAddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.browseImage = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hp_checkB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productNameTb
            // 
            this.productNameTb.Location = new System.Drawing.Point(176, 37);
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(100, 20);
            this.productNameTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description : ";
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(176, 92);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.Size = new System.Drawing.Size(886, 80);
            this.descriptionRTB.TabIndex = 4;
            this.descriptionRTB.Text = "";
            // 
            // browseImage
            // 
            this.browseImage.Location = new System.Drawing.Point(728, 63);
            this.browseImage.Name = "browseImage";
            this.browseImage.Size = new System.Drawing.Size(83, 23);
            this.browseImage.TabIndex = 6;
            this.browseImage.Text = "Browse Image";
            this.browseImage.UseVisualStyleBackColor = true;
            this.browseImage.Click += new System.EventHandler(this.browseImage_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(728, 34);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(293, 37);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price : ";
            // 
            // categoriesCB
            // 
            this.categoriesCB.FormattingEnabled = true;
            this.categoriesCB.Location = new System.Drawing.Point(409, 36);
            this.categoriesCB.Name = "categoriesCB";
            this.categoriesCB.Size = new System.Drawing.Size(121, 21);
            this.categoriesCB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categories :";
            // 
            // hp_checkB
            // 
            this.hp_checkB.AutoSize = true;
            this.hp_checkB.Location = new System.Drawing.Point(547, 39);
            this.hp_checkB.Name = "hp_checkB";
            this.hp_checkB.Size = new System.Drawing.Size(92, 17);
            this.hp_checkB.TabIndex = 12;
            this.hp_checkB.Text = "Hot Product ?";
            this.hp_checkB.UseVisualStyleBackColor = true;
            // 
            // adminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.hp_checkB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoriesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.save);
            this.Controls.Add(this.browseImage);
            this.Controls.Add(this.descriptionRTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameTb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminAddProduct";
            this.Size = new System.Drawing.Size(1080, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox productNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.Button browseImage;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoriesCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hp_checkB;
    }
}
