namespace Shopping_Application
{
    partial class Cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.clear_cart = new System.Windows.Forms.Button();
            this.place_order = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adressCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(584, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            // 
            // clear_cart
            // 
            this.clear_cart.Location = new System.Drawing.Point(427, 574);
            this.clear_cart.Name = "clear_cart";
            this.clear_cart.Size = new System.Drawing.Size(158, 60);
            this.clear_cart.TabIndex = 2;
            this.clear_cart.Text = "Clear Cart";
            this.clear_cart.UseVisualStyleBackColor = true;
            this.clear_cart.Click += new System.EventHandler(this.clear_cart_Click);
            // 
            // place_order
            // 
            this.place_order.Location = new System.Drawing.Point(591, 574);
            this.place_order.Name = "place_order";
            this.place_order.Size = new System.Drawing.Size(158, 60);
            this.place_order.TabIndex = 3;
            this.place_order.Text = "Place Order";
            this.place_order.UseVisualStyleBackColor = true;
            this.place_order.Click += new System.EventHandler(this.place_order_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(4, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 526);
            this.panel1.TabIndex = 4;
            // 
            // adressCB
            // 
            this.adressCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adressCB.FormattingEnabled = true;
            this.adressCB.Location = new System.Drawing.Point(764, 574);
            this.adressCB.Name = "adressCB";
            this.adressCB.Size = new System.Drawing.Size(182, 28);
            this.adressCB.TabIndex = 5;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adressCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.place_order);
            this.Controls.Add(this.clear_cart);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1279, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_cart;
        private System.Windows.Forms.Button place_order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox adressCB;
    }
}
