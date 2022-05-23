
namespace Login
{
    partial class FormDoctorSearch
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
            this.sort_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.sort_btn = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.search_cb = new System.Windows.Forms.ComboBox();
            this.checkup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // sort_cb
            // 
            this.sort_cb.FormattingEnabled = true;
            this.sort_cb.Location = new System.Drawing.Point(838, 242);
            this.sort_cb.Name = "sort_cb";
            this.sort_cb.Size = new System.Drawing.Size(148, 28);
            this.sort_cb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(834, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sortiraj po:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(838, 142);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(148, 50);
            this.search_btn.TabIndex = 24;
            this.search_btn.Text = "Pretrazi";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(834, 34);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(89, 20);
            this.search_lbl.TabIndex = 23;
            this.search_lbl.Text = "Pretrazi po:";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(838, 101);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(148, 26);
            this.search_tb.TabIndex = 22;
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(838, 276);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(148, 46);
            this.sort_btn.TabIndex = 21;
            this.sort_btn.Text = "Sortiraj";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click_1);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowHeadersWidth = 62;
            this.dataGridViewDoctors.RowTemplate.Height = 28;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(781, 438);
            this.dataGridViewDoctors.TabIndex = 20;
            // 
            // search_cb
            // 
            this.search_cb.FormattingEnabled = true;
            this.search_cb.Location = new System.Drawing.Point(839, 67);
            this.search_cb.Name = "search_cb";
            this.search_cb.Size = new System.Drawing.Size(148, 28);
            this.search_cb.TabIndex = 27;
            // 
            // checkup_btn
            // 
            this.checkup_btn.Location = new System.Drawing.Point(839, 404);
            this.checkup_btn.Name = "checkup_btn";
            this.checkup_btn.Size = new System.Drawing.Size(148, 46);
            this.checkup_btn.TabIndex = 28;
            this.checkup_btn.Text = "Zakazi pregled";
            this.checkup_btn.UseVisualStyleBackColor = true;
            this.checkup_btn.Click += new System.EventHandler(this.checkup_btn_Click);
            // 
            // FormDoctorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 496);
            this.Controls.Add(this.checkup_btn);
            this.Controls.Add(this.search_cb);
            this.Controls.Add(this.sort_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Name = "FormDoctorSearch";
            this.Text = "FormDoctorSearch";
            this.Load += new System.EventHandler(this.FormDoctorSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sort_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.ComboBox search_cb;
        private System.Windows.Forms.Button checkup_btn;
    }
}