
namespace Login.Secretary
{
    partial class FreeDayRequestForm
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
            this.approveRequest_btn = new System.Windows.Forms.Button();
            this.rejectRequest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requests_cb
            // 
            this.requests_cb.FormattingEnabled = true;
            this.requests_cb.Location = new System.Drawing.Point(76, 63);
            this.requests_cb.Name = "requests_cb";
            this.requests_cb.Size = new System.Drawing.Size(217, 21);
            this.requests_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabir zahteva";
            // 
            // approveRequest_btn
            // 
            this.approveRequest_btn.Location = new System.Drawing.Point(39, 171);
            this.approveRequest_btn.Name = "approveRequest_btn";
            this.approveRequest_btn.Size = new System.Drawing.Size(138, 48);
            this.approveRequest_btn.TabIndex = 2;
            this.approveRequest_btn.Text = "Odobri";
            this.approveRequest_btn.UseVisualStyleBackColor = true;
            this.approveRequest_btn.Click += new System.EventHandler(this.approveRequest_btn_Click);
            // 
            // rejectRequest_btn
            // 
            this.rejectRequest_btn.Location = new System.Drawing.Point(215, 171);
            this.rejectRequest_btn.Name = "rejectRequest_btn";
            this.rejectRequest_btn.Size = new System.Drawing.Size(138, 48);
            this.rejectRequest_btn.TabIndex = 3;
            this.rejectRequest_btn.Text = "Odbij";
            this.rejectRequest_btn.UseVisualStyleBackColor = true;
            this.rejectRequest_btn.Click += new System.EventHandler(this.rejectRequest_btn_Click);
            // 
            // FreeDayRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 317);
            this.Controls.Add(this.rejectRequest_btn);
            this.Controls.Add(this.approveRequest_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requests_cb);
            this.Name = "FreeDayRequestForm";
            this.Text = "FreeDayRequestForm";
            this.Load += new System.EventHandler(this.FreeDayRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox requests_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approveRequest_btn;
        private System.Windows.Forms.Button rejectRequest_btn;
    }
}