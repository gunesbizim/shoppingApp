namespace Shopping_Application
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cart_total_price_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cart_item_count_label = new System.Windows.Forms.Label();
            this.cart_label1 = new System.Windows.Forms.Label();
            this.cartImage = new System.Windows.Forms.PictureBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appname = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.cart_total_price_label);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.cart_item_count_label);
            this.main_panel.Controls.Add(this.cart_label1);
            this.main_panel.Controls.Add(this.cartImage);
            this.main_panel.Controls.Add(this.userImage);
            this.main_panel.Controls.Add(this.username_label);
            this.main_panel.Controls.Add(this.appname);
            this.main_panel.Location = new System.Drawing.Point(1, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1267, 61);
            this.main_panel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turkish Lira(s)";
            // 
            // cart_total_price_label
            // 
            this.cart_total_price_label.AutoSize = true;
            this.cart_total_price_label.Location = new System.Drawing.Point(851, 43);
            this.cart_total_price_label.Name = "cart_total_price_label";
            this.cart_total_price_label.Size = new System.Drawing.Size(14, 13);
            this.cart_total_price_label.TabIndex = 7;
            this.cart_total_price_label.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product(s)";
            // 
            // cart_item_count_label
            // 
            this.cart_item_count_label.AutoSize = true;
            this.cart_item_count_label.Location = new System.Drawing.Point(851, 27);
            this.cart_item_count_label.Name = "cart_item_count_label";
            this.cart_item_count_label.Size = new System.Drawing.Size(14, 13);
            this.cart_item_count_label.TabIndex = 5;
            this.cart_item_count_label.Text = "X";
            // 
            // cart_label1
            // 
            this.cart_label1.AutoSize = true;
            this.cart_label1.Location = new System.Drawing.Point(851, 6);
            this.cart_label1.Name = "cart_label1";
            this.cart_label1.Size = new System.Drawing.Size(35, 13);
            this.cart_label1.TabIndex = 4;
            this.cart_label1.Text = "Cart : ";
            // 
            // cartImage
            // 
            this.cartImage.ImageLocation = "https://i.hizliresim.com/grGk4Z.png";
            this.cartImage.Location = new System.Drawing.Point(798, 11);
            this.cartImage.Name = "cartImage";
            this.cartImage.Size = new System.Drawing.Size(38, 34);
            this.cartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartImage.TabIndex = 3;
            this.cartImage.TabStop = false;
            this.cartImage.Click += new System.EventHandler(this.cartImage_Click);
            // 
            // userImage
            // 
            this.userImage.ImageLocation = "https://i.hizliresim.com/9a7V9o.png";
            this.userImage.Location = new System.Drawing.Point(1116, 6);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(38, 34);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 2;
            this.userImage.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.ContextMenuStrip = this.userMenu;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_label.Location = new System.Drawing.Point(1160, 6);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(69, 13);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "User Name";
            // 
            // userMenu
            // 
            this.userMenu.Name = "contextMenuStrip1";
            this.userMenu.Size = new System.Drawing.Size(61, 4);
            this.userMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.userMenu_ItemClicked);
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.BackColor = System.Drawing.Color.Transparent;
            this.appname.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appname.Location = new System.Drawing.Point(5, 6);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(266, 50);
            this.appname.TabIndex = 0;
            this.appname.Text = "Easy Shopping";
            this.appname.Click += new System.EventHandler(this.appname_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 601);
            this.Controls.Add(this.main_panel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Application";
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label appname;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label cart_total_price_label;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label cart_item_count_label;
        private System.Windows.Forms.Label cart_label1;
        private System.Windows.Forms.PictureBox cartImage;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.ImageList imageList1;
    }
}

