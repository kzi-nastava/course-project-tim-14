
namespace Login
{
    partial class ClosestRecommendations
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
            this.checkup1_rb = new System.Windows.Forms.RadioButton();
            this.checkup2_rb = new System.Windows.Forms.RadioButton();
            this.checkup3_rb = new System.Windows.Forms.RadioButton();
            this.approve_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkup1_rb
            // 
            this.checkup1_rb.AutoSize = true;
            this.checkup1_rb.Location = new System.Drawing.Point(45, 40);
            this.checkup1_rb.Name = "checkup1_rb";
            this.checkup1_rb.Size = new System.Drawing.Size(126, 24);
            this.checkup1_rb.TabIndex = 0;
            this.checkup1_rb.TabStop = true;
            this.checkup1_rb.Text = "radioButton1";
            this.checkup1_rb.UseVisualStyleBackColor = true;
            // 
            // checkup2_rb
            // 
            this.checkup2_rb.AutoSize = true;
            this.checkup2_rb.Location = new System.Drawing.Point(45, 96);
            this.checkup2_rb.Name = "checkup2_rb";
            this.checkup2_rb.Size = new System.Drawing.Size(126, 24);
            this.checkup2_rb.TabIndex = 1;
            this.checkup2_rb.TabStop = true;
            this.checkup2_rb.Text = "radioButton2";
            this.checkup2_rb.UseVisualStyleBackColor = true;
            // 
            // checkup3_rb
            // 
            this.checkup3_rb.AutoSize = true;
            this.checkup3_rb.Location = new System.Drawing.Point(45, 150);
            this.checkup3_rb.Name = "checkup3_rb";
            this.checkup3_rb.Size = new System.Drawing.Size(126, 24);
            this.checkup3_rb.TabIndex = 2;
            this.checkup3_rb.TabStop = true;
            this.checkup3_rb.Text = "radioButton3";
            this.checkup3_rb.UseVisualStyleBackColor = true;
            // 
            // approve_btn
            // 
            this.approve_btn.Location = new System.Drawing.Point(127, 247);
            this.approve_btn.Name = "approve_btn";
            this.approve_btn.Size = new System.Drawing.Size(125, 43);
            this.approve_btn.TabIndex = 3;
            this.approve_btn.Text = "Zakazi";
            this.approve_btn.UseVisualStyleBackColor = true;
            this.approve_btn.Click += new System.EventHandler(this.approve_btn_Click);
            // 
            // ClosestRecommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 342);
            this.Controls.Add(this.approve_btn);
            this.Controls.Add(this.checkup3_rb);
            this.Controls.Add(this.checkup2_rb);
            this.Controls.Add(this.checkup1_rb);
            this.Name = "ClosestRecommendations";
            this.Text = "ClosestRecommendations";
            this.Load += new System.EventHandler(this.ClosestRecommendations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton checkup1_rb;
        private System.Windows.Forms.RadioButton checkup2_rb;
        private System.Windows.Forms.RadioButton checkup3_rb;
        private System.Windows.Forms.Button approve_btn;
    }
}