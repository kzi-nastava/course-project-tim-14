
namespace Login
{
    partial class FormMedicalHistory
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
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.sort_btn = new System.Windows.Forms.Button();
            this.dataGridViewCheckups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sort_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckups)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(772, 88);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(148, 50);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "Pretrazi";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(768, 33);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(153, 20);
            this.search_lbl.TabIndex = 13;
            this.search_lbl.Text = "Pretraga anamneza:";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(772, 56);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(148, 26);
            this.search_tb.TabIndex = 12;
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(772, 240);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(148, 46);
            this.sort_btn.TabIndex = 11;
            this.sort_btn.Text = "Sortiraj";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // dataGridViewCheckups
            // 
            this.dataGridViewCheckups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckups.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCheckups.Name = "dataGridViewCheckups";
            this.dataGridViewCheckups.RowHeadersWidth = 62;
            this.dataGridViewCheckups.RowTemplate.Height = 28;
            this.dataGridViewCheckups.Size = new System.Drawing.Size(741, 438);
            this.dataGridViewCheckups.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sortiraj po:";
            // 
            // sort_cb
            // 
            this.sort_cb.FormattingEnabled = true;
            this.sort_cb.Location = new System.Drawing.Point(772, 207);
            this.sort_cb.Name = "sort_cb";
            this.sort_cb.Size = new System.Drawing.Size(148, 28);
            this.sort_cb.TabIndex = 19;
            // 
            // FormMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 468);
            this.Controls.Add(this.sort_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.dataGridViewCheckups);
            this.Name = "FormMedicalHistory";
            this.Text = "FormMedicalHistory";
            this.Load += new System.EventHandler(this.FormMedicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.DataGridView dataGridViewCheckups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sort_cb;
    }
}