
namespace Login
{
    partial class FormSurvey
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
            this.submit_btn = new System.Windows.Forms.Button();
            this.quality_lbl = new System.Windows.Forms.Label();
            this.quality_cb = new System.Windows.Forms.ComboBox();
            this.hygiene_cb = new System.Windows.Forms.ComboBox();
            this.hygiene_lbl = new System.Windows.Forms.Label();
            this.rating_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recommend_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(165, 361);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(171, 60);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Pošalji";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // quality_lbl
            // 
            this.quality_lbl.AutoSize = true;
            this.quality_lbl.Location = new System.Drawing.Point(72, 31);
            this.quality_lbl.Name = "quality_lbl";
            this.quality_lbl.Size = new System.Drawing.Size(111, 20);
            this.quality_lbl.TabIndex = 1;
            this.quality_lbl.Text = "Kvalitet usluge";
            // 
            // quality_cb
            // 
            this.quality_cb.FormattingEnabled = true;
            this.quality_cb.Location = new System.Drawing.Point(76, 66);
            this.quality_cb.Name = "quality_cb";
            this.quality_cb.Size = new System.Drawing.Size(121, 28);
            this.quality_cb.TabIndex = 2;
            // 
            // hygiene_cb
            // 
            this.hygiene_cb.FormattingEnabled = true;
            this.hygiene_cb.Location = new System.Drawing.Point(258, 66);
            this.hygiene_cb.Name = "hygiene_cb";
            this.hygiene_cb.Size = new System.Drawing.Size(121, 28);
            this.hygiene_cb.TabIndex = 4;
            // 
            // hygiene_lbl
            // 
            this.hygiene_lbl.AutoSize = true;
            this.hygiene_lbl.Location = new System.Drawing.Point(254, 31);
            this.hygiene_lbl.Name = "hygiene_lbl";
            this.hygiene_lbl.Size = new System.Drawing.Size(62, 20);
            this.hygiene_lbl.TabIndex = 3;
            this.hygiene_lbl.Text = "Čistoća";
            // 
            // rating_cb
            // 
            this.rating_cb.FormattingEnabled = true;
            this.rating_cb.Location = new System.Drawing.Point(75, 164);
            this.rating_cb.Name = "rating_cb";
            this.rating_cb.Size = new System.Drawing.Size(121, 28);
            this.rating_cb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Da li ste zadovoljni";
            // 
            // recommend_cb
            // 
            this.recommend_cb.FormattingEnabled = true;
            this.recommend_cb.Location = new System.Drawing.Point(258, 164);
            this.recommend_cb.Name = "recommend_cb";
            this.recommend_cb.Size = new System.Drawing.Size(121, 28);
            this.recommend_cb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Da li biste preporucili prijateljima";
            // 
            // comment_tb
            // 
            this.comment_tb.Location = new System.Drawing.Point(75, 271);
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(349, 26);
            this.comment_tb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ostavite komentar";
            // 
            // FormSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_tb);
            this.Controls.Add(this.recommend_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rating_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hygiene_cb);
            this.Controls.Add(this.hygiene_lbl);
            this.Controls.Add(this.quality_cb);
            this.Controls.Add(this.quality_lbl);
            this.Controls.Add(this.submit_btn);
            this.Name = "FormSurvey";
            this.Text = "FormSurvey";
            this.Load += new System.EventHandler(this.FormSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label quality_lbl;
        private System.Windows.Forms.ComboBox quality_cb;
        private System.Windows.Forms.ComboBox hygiene_cb;
        private System.Windows.Forms.Label hygiene_lbl;
        private System.Windows.Forms.ComboBox rating_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recommend_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comment_tb;
        private System.Windows.Forms.Label label1;
    }
}