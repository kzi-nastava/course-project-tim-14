
namespace Login
{
    partial class FormCreateCheckup
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
            this.checkup_date = new System.Windows.Forms.DateTimePicker();
            this.date_time_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.time_cb = new System.Windows.Forms.ComboBox();
            this.doctor_lbl = new System.Windows.Forms.Label();
            this.doctor_cb = new System.Windows.Forms.ComboBox();
            this.create_checkup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkup_date
            // 
            this.checkup_date.Location = new System.Drawing.Point(133, 67);
            this.checkup_date.Name = "checkup_date";
            this.checkup_date.Size = new System.Drawing.Size(200, 26);
            this.checkup_date.TabIndex = 0;
            // 
            // date_time_lbl
            // 
            this.date_time_lbl.AutoSize = true;
            this.date_time_lbl.Location = new System.Drawing.Point(133, 41);
            this.date_time_lbl.Name = "date_time_lbl";
            this.date_time_lbl.Size = new System.Drawing.Size(123, 20);
            this.date_time_lbl.TabIndex = 1;
            this.date_time_lbl.Text = "Datum pregleda";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(137, 100);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(122, 20);
            this.time_lbl.TabIndex = 2;
            this.time_lbl.Text = "Vreme pregleda";
            // 
            // time_cb
            // 
            this.time_cb.FormattingEnabled = true;
            this.time_cb.Location = new System.Drawing.Point(133, 124);
            this.time_cb.Name = "time_cb";
            this.time_cb.Size = new System.Drawing.Size(200, 28);
            this.time_cb.TabIndex = 3;
            // 
            // doctor_lbl
            // 
            this.doctor_lbl.AutoSize = true;
            this.doctor_lbl.Location = new System.Drawing.Point(133, 159);
            this.doctor_lbl.Name = "doctor_lbl";
            this.doctor_lbl.Size = new System.Drawing.Size(57, 20);
            this.doctor_lbl.TabIndex = 4;
            this.doctor_lbl.Text = "Doktor";
            // 
            // doctor_cb
            // 
            this.doctor_cb.FormattingEnabled = true;
            this.doctor_cb.Location = new System.Drawing.Point(133, 183);
            this.doctor_cb.Name = "doctor_cb";
            this.doctor_cb.Size = new System.Drawing.Size(200, 28);
            this.doctor_cb.TabIndex = 5;
            // 
            // create_checkup
            // 
            this.create_checkup.Location = new System.Drawing.Point(175, 251);
            this.create_checkup.Name = "create_checkup";
            this.create_checkup.Size = new System.Drawing.Size(101, 37);
            this.create_checkup.TabIndex = 6;
            this.create_checkup.Text = "Zakazi";
            this.create_checkup.UseVisualStyleBackColor = true;
            this.create_checkup.Click += new System.EventHandler(this.create_checkup_Click);
            // 
            // FormCreateCheckup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 443);
            this.Controls.Add(this.create_checkup);
            this.Controls.Add(this.doctor_cb);
            this.Controls.Add(this.doctor_lbl);
            this.Controls.Add(this.time_cb);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.date_time_lbl);
            this.Controls.Add(this.checkup_date);
            this.Name = "FormCreateCheckup";
            this.Text = "FormCreateCheckup";
            this.Load += new System.EventHandler(this.FormCreateCheckup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkup_date;
        private System.Windows.Forms.Label date_time_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.ComboBox time_cb;
        private System.Windows.Forms.Label doctor_lbl;
        private System.Windows.Forms.ComboBox doctor_cb;
        private System.Windows.Forms.Button create_checkup;
    }
}