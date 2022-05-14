
namespace Login
{
    partial class FormRecommendation
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
            this.doctor_cb = new System.Windows.Forms.ComboBox();
            this.from_time_cb = new System.Windows.Forms.ComboBox();
            this.to_time_cb = new System.Windows.Forms.ComboBox();
            this.doctor_lbl = new System.Windows.Forms.Label();
            this.from_time_lbl = new System.Windows.Forms.Label();
            this.to_time_lbl = new System.Windows.Forms.Label();
            this.to_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.to_date_lbl = new System.Windows.Forms.Label();
            this.doctor_rb = new System.Windows.Forms.RadioButton();
            this.time_rb = new System.Windows.Forms.RadioButton();
            this.recommend_btn = new System.Windows.Forms.Button();
            this.priority_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctor_cb
            // 
            this.doctor_cb.FormattingEnabled = true;
            this.doctor_cb.Location = new System.Drawing.Point(147, 47);
            this.doctor_cb.Name = "doctor_cb";
            this.doctor_cb.Size = new System.Drawing.Size(121, 28);
            this.doctor_cb.TabIndex = 0;
            // 
            // from_time_cb
            // 
            this.from_time_cb.FormattingEnabled = true;
            this.from_time_cb.Location = new System.Drawing.Point(147, 118);
            this.from_time_cb.Name = "from_time_cb";
            this.from_time_cb.Size = new System.Drawing.Size(121, 28);
            this.from_time_cb.TabIndex = 1;
            // 
            // to_time_cb
            // 
            this.to_time_cb.FormattingEnabled = true;
            this.to_time_cb.Location = new System.Drawing.Point(147, 183);
            this.to_time_cb.Name = "to_time_cb";
            this.to_time_cb.Size = new System.Drawing.Size(121, 28);
            this.to_time_cb.TabIndex = 2;
            // 
            // doctor_lbl
            // 
            this.doctor_lbl.AutoSize = true;
            this.doctor_lbl.Location = new System.Drawing.Point(147, 13);
            this.doctor_lbl.Name = "doctor_lbl";
            this.doctor_lbl.Size = new System.Drawing.Size(61, 20);
            this.doctor_lbl.TabIndex = 3;
            this.doctor_lbl.Text = "Doktor:";
            // 
            // from_time_lbl
            // 
            this.from_time_lbl.AutoSize = true;
            this.from_time_lbl.Location = new System.Drawing.Point(147, 95);
            this.from_time_lbl.Name = "from_time_lbl";
            this.from_time_lbl.Size = new System.Drawing.Size(34, 20);
            this.from_time_lbl.TabIndex = 4;
            this.from_time_lbl.Text = "Od:";
            // 
            // to_time_lbl
            // 
            this.to_time_lbl.AutoSize = true;
            this.to_time_lbl.Location = new System.Drawing.Point(147, 160);
            this.to_time_lbl.Name = "to_time_lbl";
            this.to_time_lbl.Size = new System.Drawing.Size(34, 20);
            this.to_time_lbl.TabIndex = 5;
            this.to_time_lbl.Text = "Do:";
            // 
            // to_date_dtp
            // 
            this.to_date_dtp.Location = new System.Drawing.Point(147, 246);
            this.to_date_dtp.Name = "to_date_dtp";
            this.to_date_dtp.Size = new System.Drawing.Size(200, 26);
            this.to_date_dtp.TabIndex = 6;
            // 
            // to_date_lbl
            // 
            this.to_date_lbl.AutoSize = true;
            this.to_date_lbl.Location = new System.Drawing.Point(147, 223);
            this.to_date_lbl.Name = "to_date_lbl";
            this.to_date_lbl.Size = new System.Drawing.Size(74, 20);
            this.to_date_lbl.TabIndex = 7;
            this.to_date_lbl.Text = "Do dana:";
            // 
            // doctor_rb
            // 
            this.doctor_rb.AutoSize = true;
            this.doctor_rb.Location = new System.Drawing.Point(147, 315);
            this.doctor_rb.Name = "doctor_rb";
            this.doctor_rb.Size = new System.Drawing.Size(82, 24);
            this.doctor_rb.TabIndex = 8;
            this.doctor_rb.TabStop = true;
            this.doctor_rb.Text = "Doktor";
            this.doctor_rb.UseVisualStyleBackColor = true;
            // 
            // time_rb
            // 
            this.time_rb.AutoSize = true;
            this.time_rb.Location = new System.Drawing.Point(235, 315);
            this.time_rb.Name = "time_rb";
            this.time_rb.Size = new System.Drawing.Size(81, 24);
            this.time_rb.TabIndex = 9;
            this.time_rb.TabStop = true;
            this.time_rb.Text = "Vreme";
            this.time_rb.UseVisualStyleBackColor = true;
            // 
            // recommend_btn
            // 
            this.recommend_btn.Location = new System.Drawing.Point(161, 355);
            this.recommend_btn.Name = "recommend_btn";
            this.recommend_btn.Size = new System.Drawing.Size(97, 37);
            this.recommend_btn.TabIndex = 10;
            this.recommend_btn.Text = "Preporuci";
            this.recommend_btn.UseVisualStyleBackColor = true;
            // 
            // priority_lbl
            // 
            this.priority_lbl.AutoSize = true;
            this.priority_lbl.Location = new System.Drawing.Point(143, 292);
            this.priority_lbl.Name = "priority_lbl";
            this.priority_lbl.Size = new System.Drawing.Size(67, 20);
            this.priority_lbl.TabIndex = 11;
            this.priority_lbl.Text = "Prioritet:";
            // 
            // FormRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 471);
            this.Controls.Add(this.priority_lbl);
            this.Controls.Add(this.recommend_btn);
            this.Controls.Add(this.time_rb);
            this.Controls.Add(this.doctor_rb);
            this.Controls.Add(this.to_date_lbl);
            this.Controls.Add(this.to_date_dtp);
            this.Controls.Add(this.to_time_lbl);
            this.Controls.Add(this.from_time_lbl);
            this.Controls.Add(this.doctor_lbl);
            this.Controls.Add(this.to_time_cb);
            this.Controls.Add(this.from_time_cb);
            this.Controls.Add(this.doctor_cb);
            this.Name = "FormRecommendation";
            this.Text = "Recommendations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doctor_cb;
        private System.Windows.Forms.ComboBox from_time_cb;
        private System.Windows.Forms.ComboBox to_time_cb;
        private System.Windows.Forms.Label doctor_lbl;
        private System.Windows.Forms.Label from_time_lbl;
        private System.Windows.Forms.Label to_time_lbl;
        private System.Windows.Forms.DateTimePicker to_date_dtp;
        private System.Windows.Forms.Label to_date_lbl;
        private System.Windows.Forms.RadioButton doctor_rb;
        private System.Windows.Forms.RadioButton time_rb;
        private System.Windows.Forms.Button recommend_btn;
        private System.Windows.Forms.Label priority_lbl;
    }
}