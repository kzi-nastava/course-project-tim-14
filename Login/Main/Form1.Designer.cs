
namespace Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(114, 240);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(139, 29);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(114, 98);
            this.email_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(139, 22);
            this.email_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(114, 142);
            this.password_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(139, 22);
            this.password_tb.TabIndex = 2;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(114, 78);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            this.email.Click += new System.EventHandler(this.label_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(114, 125);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(68, 17);
            this.password.TabIndex = 4;
            this.password.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 298);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.login_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
    }
}

