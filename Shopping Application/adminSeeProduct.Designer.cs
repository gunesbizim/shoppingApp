namespace Shopping_Application
{
    partial class adminSeeProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.editBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            // 
            // nameTB
            // 
            this.nameTB.AutoSize = true;
            this.nameTB.Location = new System.Drawing.Point(197, 22);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(35, 13);
            this.nameTB.TabIndex = 2;
            this.nameTB.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price : ";
            // 
            // priceTB
            // 
            this.priceTB.AutoSize = true;
            this.priceTB.Location = new System.Drawing.Point(197, 50);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(44, 13);
            this.priceTB.TabIndex = 4;
            this.priceTB.Text = "priceTB";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(274, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 128);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // editBT
            // 
            this.editBT.Location = new System.Drawing.Point(624, 22);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(75, 23);
            this.editBT.TabIndex = 6;
            this.editBT.Text = "Edit";
            this.editBT.UseVisualStyleBackColor = true;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(624, 51);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(75, 23);
            this.deleteBT.TabIndex = 7;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // adminSeeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminSeeProduct";
            this.Size = new System.Drawing.Size(723, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceTB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Button deleteBT;
    }
}
