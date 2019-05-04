namespace Shopping_Application
{
    partial class ProductDetail
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
            this.button1 = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Label();
            this.keyTb = new System.Windows.Forms.TextBox();
            this.valueTb = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(3, 8);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(52, 13);
            this.key.TabIndex = 1;
            this.key.Text = "Property :";
            // 
            // keyTb
            // 
            this.keyTb.Location = new System.Drawing.Point(6, 24);
            this.keyTb.Name = "keyTb";
            this.keyTb.Size = new System.Drawing.Size(100, 20);
            this.keyTb.TabIndex = 2;
            // 
            // valueTb
            // 
            this.valueTb.Location = new System.Drawing.Point(125, 24);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(100, 20);
            this.valueTb.TabIndex = 3;
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(122, 8);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(40, 13);
            this.value.TabIndex = 4;
            this.value.Text = "Value :";
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.value);
            this.Controls.Add(this.valueTb);
            this.Controls.Add(this.keyTb);
            this.Controls.Add(this.key);
            this.Controls.Add(this.button1);
            this.Name = "ProductDetail";
            this.Size = new System.Drawing.Size(315, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.TextBox keyTb;
        private System.Windows.Forms.TextBox valueTb;
        private System.Windows.Forms.Label value;
    }
}
