
namespace Login.Secretary
{
    partial class AccountEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientEditID_tb = new System.Windows.Forms.TextBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ID pacijenta ciji nalog zelite da izmenite";
            // 
            // patientEditID_tb
            // 
            this.patientEditID_tb.Location = new System.Drawing.Point(54, 88);
            this.patientEditID_tb.Name = "patientEditID_tb";
            this.patientEditID_tb.Size = new System.Drawing.Size(127, 22);
            this.patientEditID_tb.TabIndex = 1;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(211, 88);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(146, 47);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = "Dalje";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // AccountEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 164);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.patientEditID_tb);
            this.Controls.Add(this.label1);
            this.Name = "AccountEditForm";
            this.Text = "AccountEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientEditID_tb;
        private System.Windows.Forms.Button next_btn;
    }
}