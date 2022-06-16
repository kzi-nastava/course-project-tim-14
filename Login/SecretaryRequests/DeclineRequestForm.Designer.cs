
namespace Login.Secretary
{
    partial class DeclineRequestForm
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
            this.explanation_tb = new System.Windows.Forms.TextBox();
            this.confirmRejection_btn = new System.Windows.Forms.Button();
            this.cancelRejection_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obrazlozenje za odbijanje zahteva";
            // 
            // explanation_tb
            // 
            this.explanation_tb.Location = new System.Drawing.Point(50, 97);
            this.explanation_tb.Multiline = true;
            this.explanation_tb.Name = "explanation_tb";
            this.explanation_tb.Size = new System.Drawing.Size(304, 85);
            this.explanation_tb.TabIndex = 1;
            // 
            // confirmRejection_btn
            // 
            this.confirmRejection_btn.Location = new System.Drawing.Point(120, 232);
            this.confirmRejection_btn.Name = "confirmRejection_btn";
            this.confirmRejection_btn.Size = new System.Drawing.Size(148, 55);
            this.confirmRejection_btn.TabIndex = 2;
            this.confirmRejection_btn.Text = "Odbij zahtev";
            this.confirmRejection_btn.UseVisualStyleBackColor = true;
            this.confirmRejection_btn.Click += new System.EventHandler(this.confirmRejection_btn_Click);
            // 
            // cancelRejection_btn
            // 
            this.cancelRejection_btn.Location = new System.Drawing.Point(120, 320);
            this.cancelRejection_btn.Name = "cancelRejection_btn";
            this.cancelRejection_btn.Size = new System.Drawing.Size(148, 55);
            this.cancelRejection_btn.TabIndex = 3;
            this.cancelRejection_btn.Text = "Odustani od odbijanja";
            this.cancelRejection_btn.UseVisualStyleBackColor = true;
            this.cancelRejection_btn.Click += new System.EventHandler(this.cancelRejection_btn_Click);
            // 
            // DeclineRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.cancelRejection_btn);
            this.Controls.Add(this.confirmRejection_btn);
            this.Controls.Add(this.explanation_tb);
            this.Controls.Add(this.label1);
            this.Name = "DeclineRequestForm";
            this.Text = "DeclineRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox explanation_tb;
        private System.Windows.Forms.Button confirmRejection_btn;
        private System.Windows.Forms.Button cancelRejection_btn;
    }
}