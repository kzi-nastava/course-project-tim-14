
namespace Login.Secretary
{
    partial class AccountCreationForm
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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.height_tb = new System.Windows.Forms.TextBox();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.illness_tb = new System.Windows.Forms.TextBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.alergies_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(252, 39);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 22);
            this.name_tb.TabIndex = 0;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(252, 85);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(100, 22);
            this.lastName_tb.TabIndex = 1;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(252, 136);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(100, 22);
            this.email_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(252, 186);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(100, 22);
            this.password_tb.TabIndex = 3;
            // 
            // height_tb
            // 
            this.height_tb.Location = new System.Drawing.Point(252, 236);
            this.height_tb.Name = "height_tb";
            this.height_tb.Size = new System.Drawing.Size(100, 22);
            this.height_tb.TabIndex = 4;
            // 
            // weight_tb
            // 
            this.weight_tb.Location = new System.Drawing.Point(252, 287);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(100, 22);
            this.weight_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime pacijenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime pacijenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail pacijenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lozinka pacijenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Visina pacijenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tezina pacijenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prethodne bolesti (Razdvojiti sa \";\")";
            // 
            // illness_tb
            // 
            this.illness_tb.Location = new System.Drawing.Point(458, 219);
            this.illness_tb.Multiline = true;
            this.illness_tb.Name = "illness_tb";
            this.illness_tb.Size = new System.Drawing.Size(228, 75);
            this.illness_tb.TabIndex = 14;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(586, 333);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(166, 53);
            this.done_btn.TabIndex = 15;
            this.done_btn.Text = "Gotovo";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Alergeni (Razdvojiti sa \";\")";
            // 
            // alergies_tb
            // 
            this.alergies_tb.Location = new System.Drawing.Point(458, 85);
            this.alergies_tb.Multiline = true;
            this.alergies_tb.Name = "alergies_tb";
            this.alergies_tb.Size = new System.Drawing.Size(228, 75);
            this.alergies_tb.TabIndex = 17;
            // 
            // AccountCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 408);
            this.Controls.Add(this.alergies_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.illness_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight_tb);
            this.Controls.Add(this.height_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.name_tb);
            this.Name = "AccountCreationForm";
            this.Text = "AccountCreationForm";
            this.Load += new System.EventHandler(this.AccountCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox height_tb;
        private System.Windows.Forms.TextBox weight_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox illness_tb;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox alergies_tb;
    }
}