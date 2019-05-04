namespace Shopping_Application
{
    partial class profilePage
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
            this.userName = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(611, 16);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 13);
            this.userName.TabIndex = 0;
            this.userName.Text = "UserName";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(3, 33);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(1270, 500);
            this.order.TabIndex = 1;
            this.order.TabStop = false;
            this.order.Text = "Orders";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(3, 539);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(1270, 500);
            this.address.TabIndex = 2;
            this.address.TabStop = false;
            this.address.Text = "Address";
            // 
            // profilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.address);
            this.Controls.Add(this.order);
            this.Controls.Add(this.userName);
            this.Name = "profilePage";
            this.Size = new System.Drawing.Size(1279, 1071);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.GroupBox order;
        private System.Windows.Forms.GroupBox address;
    }
}
