
namespace Login
{
    partial class FormPatient
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
            this.checkup_cb = new System.Windows.Forms.ComboBox();
            this.checkup = new System.Windows.Forms.Label();
            this.checkupCRUD_btn = new System.Windows.Forms.Button();
            this.recommend_btn = new System.Windows.Forms.Button();
            this.medical_history_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkup_cb
            // 
            this.checkup_cb.FormattingEnabled = true;
            this.checkup_cb.Items.AddRange(new object[] {
            "Zakazani pregledi",
            "Zakazi pregled",
            "Otkazi pregled",
            "Izmeni pregled"});
            this.checkup_cb.Location = new System.Drawing.Point(54, 48);
            this.checkup_cb.Name = "checkup_cb";
            this.checkup_cb.Size = new System.Drawing.Size(297, 28);
            this.checkup_cb.TabIndex = 0;
            // 
            // checkup
            // 
            this.checkup.AutoSize = true;
            this.checkup.Location = new System.Drawing.Point(50, 25);
            this.checkup.Name = "checkup";
            this.checkup.Size = new System.Drawing.Size(66, 20);
            this.checkup.TabIndex = 1;
            this.checkup.Text = "Pregledi";
            // 
            // checkupCRUD_btn
            // 
            this.checkupCRUD_btn.Location = new System.Drawing.Point(147, 98);
            this.checkupCRUD_btn.Name = "checkupCRUD_btn";
            this.checkupCRUD_btn.Size = new System.Drawing.Size(111, 34);
            this.checkupCRUD_btn.TabIndex = 2;
            this.checkupCRUD_btn.Text = "Izaberi";
            this.checkupCRUD_btn.UseVisualStyleBackColor = true;
            this.checkupCRUD_btn.Click += new System.EventHandler(this.checkupCRUD_btn_Click);
            // 
            // recommend_btn
            // 
            this.recommend_btn.Location = new System.Drawing.Point(366, 48);
            this.recommend_btn.Name = "recommend_btn";
            this.recommend_btn.Size = new System.Drawing.Size(169, 55);
            this.recommend_btn.TabIndex = 3;
            this.recommend_btn.Text = "Preporuci pregled";
            this.recommend_btn.UseVisualStyleBackColor = true;
            this.recommend_btn.Click += new System.EventHandler(this.recommend_btn_Click);
            // 
            // medical_history_btn
            // 
            this.medical_history_btn.Location = new System.Drawing.Point(574, 48);
            this.medical_history_btn.Name = "medical_history_btn";
            this.medical_history_btn.Size = new System.Drawing.Size(166, 55);
            this.medical_history_btn.TabIndex = 4;
            this.medical_history_btn.Text = "Pregled anamneza";
            this.medical_history_btn.UseVisualStyleBackColor = true;
            this.medical_history_btn.Click += new System.EventHandler(this.medical_history_btn_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medical_history_btn);
            this.Controls.Add(this.recommend_btn);
            this.Controls.Add(this.checkupCRUD_btn);
            this.Controls.Add(this.checkup);
            this.Controls.Add(this.checkup_cb);
            this.Name = "FormPatient";
            this.Text = "FormPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox checkup_cb;
        private System.Windows.Forms.Label checkup;
        private System.Windows.Forms.Button checkupCRUD_btn;
        private System.Windows.Forms.Button recommend_btn;
        private System.Windows.Forms.Button medical_history_btn;
    }
}