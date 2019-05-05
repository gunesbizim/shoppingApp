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
            this.orderP = new System.Windows.Forms.GroupBox();
            this.addNAF = new System.Windows.Forms.Button();
            this.adressP = new System.Windows.Forms.Panel();
            this.adressP.SuspendLayout();
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
            // orderP
            // 
            this.orderP.AutoSize = true;
            this.orderP.Location = new System.Drawing.Point(3, 33);
            this.orderP.Name = "orderP";
            this.orderP.Size = new System.Drawing.Size(1270, 513);
            this.orderP.TabIndex = 1;
            this.orderP.TabStop = false;
            this.orderP.Text = "Orders";
            // 
            // addNAF
            // 
            this.addNAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNAF.Location = new System.Drawing.Point(1114, 13);
            this.addNAF.Name = "addNAF";
            this.addNAF.Size = new System.Drawing.Size(143, 47);
            this.addNAF.TabIndex = 0;
            this.addNAF.Text = "Add New Adress Field";
            this.addNAF.UseVisualStyleBackColor = true;
            this.addNAF.Click += new System.EventHandler(this.addNAF_Click);
            // 
            // adressP
            // 
            this.adressP.AutoScroll = true;
            this.adressP.Controls.Add(this.addNAF);
            this.adressP.Location = new System.Drawing.Point(3, 552);
            this.adressP.Name = "adressP";
            this.adressP.Size = new System.Drawing.Size(1270, 516);
            this.adressP.TabIndex = 2;
            // 
            // profilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adressP);
            this.Controls.Add(this.orderP);
            this.Controls.Add(this.userName);
            this.Name = "profilePage";
            this.Size = new System.Drawing.Size(1279, 1071);
            this.adressP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.GroupBox orderP;
        private System.Windows.Forms.Button addNAF;
        private System.Windows.Forms.Panel adressP;
    }
}
