namespace Shopping_Application
{
    partial class adminPanel
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
            this.adminMenu = new System.Windows.Forms.GroupBox();
            this.menu_orders = new System.Windows.Forms.LinkLabel();
            this.menu_Cat = new System.Windows.Forms.LinkLabel();
            this.menu_AddProduct = new System.Windows.Forms.LinkLabel();
            this.menu_products = new System.Windows.Forms.LinkLabel();
            this.pageName = new System.Windows.Forms.Label();
            this.adminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminMenu
            // 
            this.adminMenu.Controls.Add(this.menu_orders);
            this.adminMenu.Controls.Add(this.menu_Cat);
            this.adminMenu.Controls.Add(this.menu_AddProduct);
            this.adminMenu.Controls.Add(this.menu_products);
            this.adminMenu.Location = new System.Drawing.Point(0, 3);
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(200, 570);
            this.adminMenu.TabIndex = 0;
            this.adminMenu.TabStop = false;
            this.adminMenu.Text = "Menu";
            // 
            // menu_orders
            // 
            this.menu_orders.AutoSize = true;
            this.menu_orders.Location = new System.Drawing.Point(7, 104);
            this.menu_orders.Name = "menu_orders";
            this.menu_orders.Size = new System.Drawing.Size(38, 13);
            this.menu_orders.TabIndex = 4;
            this.menu_orders.TabStop = true;
            this.menu_orders.Text = "Orders";
            this.menu_orders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menu_orders_LinkClicked);
            // 
            // menu_Cat
            // 
            this.menu_Cat.AutoSize = true;
            this.menu_Cat.Location = new System.Drawing.Point(7, 78);
            this.menu_Cat.Name = "menu_Cat";
            this.menu_Cat.Size = new System.Drawing.Size(57, 13);
            this.menu_Cat.TabIndex = 2;
            this.menu_Cat.TabStop = true;
            this.menu_Cat.Text = "Categories";
            this.menu_Cat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menu_Cat_LinkClicked);
            // 
            // menu_AddProduct
            // 
            this.menu_AddProduct.AutoSize = true;
            this.menu_AddProduct.Location = new System.Drawing.Point(7, 52);
            this.menu_AddProduct.Name = "menu_AddProduct";
            this.menu_AddProduct.Size = new System.Drawing.Size(66, 13);
            this.menu_AddProduct.TabIndex = 1;
            this.menu_AddProduct.TabStop = true;
            this.menu_AddProduct.Text = "Add Product";
            this.menu_AddProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menu_AddProduct_LinkClicked);
            // 
            // menu_products
            // 
            this.menu_products.AutoSize = true;
            this.menu_products.Location = new System.Drawing.Point(7, 29);
            this.menu_products.Name = "menu_products";
            this.menu_products.Size = new System.Drawing.Size(49, 13);
            this.menu_products.TabIndex = 0;
            this.menu_products.TabStop = true;
            this.menu_products.Text = "Products";
            this.menu_products.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menu_products_LinkClicked);
            // 
            // pageName
            // 
            this.pageName.AutoSize = true;
            this.pageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageName.Location = new System.Drawing.Point(540, 0);
            this.pageName.Name = "pageName";
            this.pageName.Size = new System.Drawing.Size(210, 37);
            this.pageName.TabIndex = 1;
            this.pageName.Text = "Admin Panel";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pageName);
            this.Controls.Add(this.adminMenu);
            this.Name = "adminPanel";
            this.Size = new System.Drawing.Size(1245, 571);
            this.adminMenu.ResumeLayout(false);
            this.adminMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox adminMenu;
        private System.Windows.Forms.LinkLabel menu_orders;
        private System.Windows.Forms.LinkLabel menu_Cat;
        private System.Windows.Forms.LinkLabel menu_AddProduct;
        private System.Windows.Forms.LinkLabel menu_products;
        private System.Windows.Forms.Label pageName;
    }
}
