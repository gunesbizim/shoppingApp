namespace Shopping_Application
{
    partial class Log_In
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
            this.signUp = new System.Windows.Forms.GroupBox();
            this.signUpBt = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.eMailTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.GroupBox();
            this.PasswordLogIn = new System.Windows.Forms.TextBox();
            this.logInBt = new System.Windows.Forms.Button();
            this.eMailLogIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp.SuspendLayout();
            this.logIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUp
            // 
            this.signUp.Controls.Add(this.signUpBt);
            this.signUp.Controls.Add(this.passwordTb);
            this.signUp.Controls.Add(this.eMailTb);
            this.signUp.Controls.Add(this.label3);
            this.signUp.Controls.Add(this.label2);
            this.signUp.Location = new System.Drawing.Point(12, 12);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(364, 149);
            this.signUp.TabIndex = 0;
            this.signUp.TabStop = false;
            this.signUp.Text = "Sign Up";
            // 
            // signUpBt
            // 
            this.signUpBt.Location = new System.Drawing.Point(237, 122);
            this.signUpBt.Name = "signUpBt";
            this.signUpBt.Size = new System.Drawing.Size(75, 23);
            this.signUpBt.TabIndex = 3;
            this.signUpBt.Text = "Sign Up";
            this.signUpBt.UseVisualStyleBackColor = true;
            this.signUpBt.Click += new System.EventHandler(this.signUpBt_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(89, 80);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(223, 20);
            this.passwordTb.TabIndex = 2;
            // 
            // eMailTb
            // 
            this.eMailTb.Location = new System.Drawing.Point(89, 35);
            this.eMailTb.Name = "eMailTb";
            this.eMailTb.Size = new System.Drawing.Size(223, 20);
            this.eMailTb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // logIn
            // 
            this.logIn.Controls.Add(this.PasswordLogIn);
            this.logIn.Controls.Add(this.logInBt);
            this.logIn.Controls.Add(this.eMailLogIn);
            this.logIn.Controls.Add(this.label5);
            this.logIn.Controls.Add(this.label4);
            this.logIn.Location = new System.Drawing.Point(12, 168);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(364, 160);
            this.logIn.TabIndex = 1;
            this.logIn.TabStop = false;
            this.logIn.Text = "Log In";
            // 
            // PasswordLogIn
            // 
            this.PasswordLogIn.Location = new System.Drawing.Point(89, 78);
            this.PasswordLogIn.Name = "PasswordLogIn";
            this.PasswordLogIn.PasswordChar = '*';
            this.PasswordLogIn.Size = new System.Drawing.Size(223, 20);
            this.PasswordLogIn.TabIndex = 5;
            // 
            // logInBt
            // 
            this.logInBt.Location = new System.Drawing.Point(237, 120);
            this.logInBt.Name = "logInBt";
            this.logInBt.Size = new System.Drawing.Size(75, 23);
            this.logInBt.TabIndex = 6;
            this.logInBt.Text = "Log In";
            this.logInBt.UseVisualStyleBackColor = true;
            this.logInBt.Click += new System.EventHandler(this.logInBt_Click);
            // 
            // eMailLogIn
            // 
            this.eMailLogIn.Location = new System.Drawing.Point(89, 34);
            this.eMailLogIn.Name = "eMailLogIn";
            this.eMailLogIn.Size = new System.Drawing.Size(223, 20);
            this.eMailLogIn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-Mail :";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 340);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.signUp);
            this.Name = "Log_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log_In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_In_FormClosed);
            this.signUp.ResumeLayout(false);
            this.signUp.PerformLayout();
            this.logIn.ResumeLayout(false);
            this.logIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signUp;
        private System.Windows.Forms.Button signUpBt;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox eMailTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox logIn;
        private System.Windows.Forms.TextBox PasswordLogIn;
        private System.Windows.Forms.Button logInBt;
        private System.Windows.Forms.TextBox eMailLogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}