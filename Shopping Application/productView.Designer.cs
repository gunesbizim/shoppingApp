namespace Shopping_Application
{
    partial class productView
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
            this.pNameTB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewBT = new System.Windows.Forms.Button();
            this.addCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pNameTB
            // 
            this.pNameTB.AutoSize = true;
            this.pNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pNameTB.Location = new System.Drawing.Point(54, 8);
            this.pNameTB.Name = "pNameTB";
            this.pNameTB.Size = new System.Drawing.Size(94, 16);
            this.pNameTB.TabIndex = 0;
            this.pNameTB.Text = "Product Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 134);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // viewBT
            // 
            this.viewBT.Location = new System.Drawing.Point(14, 167);
            this.viewBT.Name = "viewBT";
            this.viewBT.Size = new System.Drawing.Size(75, 23);
            this.viewBT.TabIndex = 2;
            this.viewBT.Text = "View";
            this.viewBT.UseVisualStyleBackColor = true;
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(109, 167);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(75, 23);
            this.addCart.TabIndex = 3;
            this.addCart.Text = "Add Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // productView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCart);
            this.Controls.Add(this.viewBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pNameTB);
            this.Name = "productView";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pNameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewBT;
        private System.Windows.Forms.Button addCart;
    }
}
