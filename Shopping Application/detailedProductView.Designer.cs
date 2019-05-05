namespace Shopping_Application
{
    partial class detailedProductView
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
            this.product_name = new System.Windows.Forms.Label();
            this.add_cart = new System.Windows.Forms.Button();
            this.count_lb = new System.Windows.Forms.Label();
            this.product_counter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.productDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_counter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.product_name.Location = new System.Drawing.Point(275, 13);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(89, 34);
            this.product_name.TabIndex = 1;
            this.product_name.Text = "label1";
            // 
            // add_cart
            // 
            this.add_cart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_cart.Location = new System.Drawing.Point(466, 229);
            this.add_cart.Name = "add_cart";
            this.add_cart.Size = new System.Drawing.Size(116, 40);
            this.add_cart.TabIndex = 2;
            this.add_cart.Text = "Add To Cart";
            this.add_cart.UseVisualStyleBackColor = true;
            this.add_cart.Click += new System.EventHandler(this.add_cart_Click);
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.count_lb.Location = new System.Drawing.Point(275, 242);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(52, 16);
            this.count_lb.TabIndex = 3;
            this.count_lb.Text = "Count :";
            // 
            // product_counter
            // 
            this.product_counter.Location = new System.Drawing.Point(333, 242);
            this.product_counter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_counter.Name = "product_counter";
            this.product_counter.Size = new System.Drawing.Size(120, 20);
            this.product_counter.TabIndex = 4;
            this.product_counter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_counter.ValueChanged += new System.EventHandler(this.product_counter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dire Gramme", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Description";
            // 
            // productDetails
            // 
            this.productDetails.AutoSize = true;
            this.productDetails.Location = new System.Drawing.Point(10, 339);
            this.productDetails.Name = "productDetails";
            this.productDetails.Size = new System.Drawing.Size(98, 13);
            this.productDetails.TabIndex = 10;
            this.productDetails.Text = "Product description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(281, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Price :";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.Location = new System.Drawing.Point(344, 78);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 16);
            this.priceLabel.TabIndex = 12;
            // 
            // detailedProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_counter);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.add_cart);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "detailedProductView";
            this.Size = new System.Drawing.Size(1279, 571);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Button add_cart;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.NumericUpDown product_counter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
    }
}
