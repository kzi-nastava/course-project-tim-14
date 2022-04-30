
namespace Login.Secretary
{
    partial class AccountDeletionForm
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
            this.deletedUserID_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletedUserID_tb
            // 
            this.deletedUserID_tb.Location = new System.Drawing.Point(66, 111);
            this.deletedUserID_tb.Name = "deletedUserID_tb";
            this.deletedUserID_tb.Size = new System.Drawing.Size(219, 22);
            this.deletedUserID_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID naloga koji zelite da obrisete";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(91, 182);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(168, 57);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Potvrdi brisanje";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // AccountDeletionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 309);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletedUserID_tb);
            this.Name = "AccountDeletionForm";
            this.Text = "AccountDeletionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletedUserID_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
    }
}