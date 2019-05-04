namespace Shopping_Application
{
    partial class Categories
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
            this.addCatNameTB = new System.Windows.Forms.TextBox();
            this.addCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.catNameUpdateTB = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name : ";
            // 
            // addCatNameTB
            // 
            this.addCatNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCatNameTB.Location = new System.Drawing.Point(195, 24);
            this.addCatNameTB.Name = "addCatNameTB";
            this.addCatNameTB.Size = new System.Drawing.Size(449, 31);
            this.addCatNameTB.TabIndex = 1;
            // 
            // addCat
            // 
            this.addCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCat.Location = new System.Drawing.Point(650, 24);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(97, 31);
            this.addCat.TabIndex = 2;
            this.addCat.Text = "Add";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(326, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category Name : ";
            // 
            // catNameUpdateTB
            // 
            this.catNameUpdateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.catNameUpdateTB.Location = new System.Drawing.Point(331, 158);
            this.catNameUpdateTB.Name = "catNameUpdateTB";
            this.catNameUpdateTB.Size = new System.Drawing.Size(449, 31);
            this.catNameUpdateTB.TabIndex = 5;
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apply.Location = new System.Drawing.Point(331, 195);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(97, 31);
            this.apply.TabIndex = 6;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categories";
            // 
            // categoriesLB
            // 
            this.categoriesLB.FormattingEnabled = true;
            this.categoriesLB.Location = new System.Drawing.Point(8, 130);
            this.categoriesLB.Name = "categoriesLB";
            this.categoriesLB.Size = new System.Drawing.Size(293, 433);
            this.categoriesLB.TabIndex = 8;
            this.categoriesLB.SelectedIndexChanged += new System.EventHandler(this.categoriesLB_SelectedIndexChanged);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriesLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.catNameUpdateTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.addCatNameTB);
            this.Controls.Add(this.label1);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(800, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCatNameTB;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catNameUpdateTB;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox categoriesLB;
    }
}
