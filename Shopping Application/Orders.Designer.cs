namespace Shopping_Application
{
    partial class Orders
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cat_gp = new System.Windows.Forms.GroupBox();
            this.order_num = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.addr_label = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cargo_num = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.cat_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cat_gp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cat_gp
            // 
            this.cat_gp.Controls.Add(this.delete);
            this.cat_gp.Controls.Add(this.update);
            this.cat_gp.Controls.Add(this.cargo_num);
            this.cat_gp.Controls.Add(this.label2);
            this.cat_gp.Controls.Add(this.comboBox1);
            this.cat_gp.Controls.Add(this.label1);
            this.cat_gp.Controls.Add(this.addr);
            this.cat_gp.Controls.Add(this.addr_label);
            this.cat_gp.Controls.Add(this.userName);
            this.cat_gp.Controls.Add(this.userName_label);
            this.cat_gp.Controls.Add(this.num);
            this.cat_gp.Controls.Add(this.order_num);
            this.cat_gp.Location = new System.Drawing.Point(3, 3);
            this.cat_gp.Name = "cat_gp";
            this.cat_gp.Size = new System.Drawing.Size(1262, 51);
            this.cat_gp.TabIndex = 0;
            this.cat_gp.TabStop = false;
            // 
            // order_num
            // 
            this.order_num.AutoSize = true;
            this.order_num.Location = new System.Drawing.Point(7, 10);
            this.order_num.Name = "order_num";
            this.order_num.Size = new System.Drawing.Size(67, 13);
            this.order_num.TabIndex = 0;
            this.order_num.Text = "Order Code :";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(80, 10);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(55, 13);
            this.num.TabIndex = 1;
            this.num.Text = "12345678";
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(7, 35);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(69, 13);
            this.userName_label.TabIndex = 2;
            this.userName_label.Text = "User Name : ";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(82, 35);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(60, 13);
            this.userName.TabIndex = 3;
            this.userName.Text = "User Name";
            // 
            // addr_label
            // 
            this.addr_label.AutoSize = true;
            this.addr_label.Location = new System.Drawing.Point(201, 10);
            this.addr_label.Name = "addr_label";
            this.addr_label.Size = new System.Drawing.Size(51, 13);
            this.addr_label.TabIndex = 4;
            this.addr_label.Text = "Address :";
            // 
            // addr
            // 
            this.addr.AutoSize = true;
            this.addr.Location = new System.Drawing.Point(258, 10);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(78, 13);
            this.addr.TabIndex = 5;
            this.addr.Text = "Address...........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Waiting for shipment",
            "Shipping Process",
            "Delivered"});
            this.comboBox1.Location = new System.Drawing.Point(254, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo Number : ";
            // 
            // cargo_num
            // 
            this.cargo_num.AutoSize = true;
            this.cargo_num.Location = new System.Drawing.Point(497, 35);
            this.cargo_num.Name = "cargo_num";
            this.cargo_num.Size = new System.Drawing.Size(67, 13);
            this.cargo_num.TabIndex = 9;
            this.cargo_num.Text = "1234567890";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(609, 27);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 10;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(707, 28);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1271, 579);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cat_gp.ResumeLayout(false);
            this.cat_gp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox cat_gp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addr;
        private System.Windows.Forms.Label addr_label;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label order_num;
        private System.Windows.Forms.Label cargo_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}
