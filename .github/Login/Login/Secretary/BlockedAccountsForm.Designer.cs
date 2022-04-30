
namespace Login.Secretary
{
    partial class BlockedAccountsForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.unblockId_tb = new System.Windows.Forms.TextBox();
            this.unblock_label = new System.Windows.Forms.Label();
            this.unblock_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(530, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // unblockId_tb
            // 
            this.unblockId_tb.Location = new System.Drawing.Point(371, 270);
            this.unblockId_tb.Name = "unblockId_tb";
            this.unblockId_tb.Size = new System.Drawing.Size(48, 22);
            this.unblockId_tb.TabIndex = 1;
            // 
            // unblock_label
            // 
            this.unblock_label.AutoSize = true;
            this.unblock_label.Location = new System.Drawing.Point(29, 273);
            this.unblock_label.Name = "unblock_label";
            this.unblock_label.Size = new System.Drawing.Size(336, 17);
            this.unblock_label.TabIndex = 2;
            this.unblock_label.Text = "Unesite ID pacijenta kom zelite da ponistite blokadu:";
            // 
            // unblock_btn
            // 
            this.unblock_btn.Location = new System.Drawing.Point(440, 258);
            this.unblock_btn.Name = "unblock_btn";
            this.unblock_btn.Size = new System.Drawing.Size(122, 46);
            this.unblock_btn.TabIndex = 3;
            this.unblock_btn.Text = "Ukloni blokadu";
            this.unblock_btn.UseVisualStyleBackColor = true;
            this.unblock_btn.Click += new System.EventHandler(this.unblock_btn_Click);
            // 
            // BlockedAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 320);
            this.Controls.Add(this.unblock_btn);
            this.Controls.Add(this.unblock_label);
            this.Controls.Add(this.unblockId_tb);
            this.Controls.Add(this.richTextBox1);
            this.Name = "BlockedAccountsForm";
            this.Text = "BlockedAccountsForm";
            this.Load += new System.EventHandler(this.BlockedAccountsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox unblockId_tb;
        private System.Windows.Forms.Label unblock_label;
        private System.Windows.Forms.Button unblock_btn;
    }
}