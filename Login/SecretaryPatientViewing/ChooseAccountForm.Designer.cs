
namespace Login.Secretary
{
    partial class ChooseAccountForm
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
            this.patientId_tb = new System.Windows.Forms.TextBox();
            this.continue_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ID pacijenta ciji nalog zelite da pogledate";
            // 
            // patientId_tb
            // 
            this.patientId_tb.Location = new System.Drawing.Point(29, 76);
            this.patientId_tb.Name = "patientId_tb";
            this.patientId_tb.Size = new System.Drawing.Size(78, 22);
            this.patientId_tb.TabIndex = 1;
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(154, 76);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(189, 41);
            this.continue_btn.TabIndex = 2;
            this.continue_btn.Text = "Dalje";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // ChooseAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 142);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.patientId_tb);
            this.Controls.Add(this.label1);
            this.Name = "ChooseAccountForm";
            this.Text = "ChooseAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientId_tb;
        private System.Windows.Forms.Button continue_btn;
    }
}