
namespace Login.Secretary
{
    partial class RequestsCheckForm
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
            this.requests_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requests_cb
            // 
            this.requests_cb.FormattingEnabled = true;
            this.requests_cb.Location = new System.Drawing.Point(49, 71);
            this.requests_cb.Name = "requests_cb";
            this.requests_cb.Size = new System.Drawing.Size(328, 24);
            this.requests_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberi zahtev";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(197, 126);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(180, 55);
            this.confirm_btn.TabIndex = 2;
            this.confirm_btn.Text = "Potvrda";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // RequestsCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 210);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requests_cb);
            this.Name = "RequestsCheckForm";
            this.Text = "RequestsCheckForm";
            this.Load += new System.EventHandler(this.RequestsCheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox requests_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
    }
}