
namespace Login.Secretary
{
    partial class CreateCheckupFromRefferalForm
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
            this.refferedCheckup_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.refferalTime_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refferalSelect_cb = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum pregleda";
            // 
            // refferedCheckup_date
            // 
            this.refferedCheckup_date.Location = new System.Drawing.Point(41, 98);
            this.refferedCheckup_date.Name = "refferedCheckup_date";
            this.refferedCheckup_date.Size = new System.Drawing.Size(192, 20);
            this.refferedCheckup_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme pregleda";
            // 
            // refferalTime_cb
            // 
            this.refferalTime_cb.FormattingEnabled = true;
            this.refferalTime_cb.Location = new System.Drawing.Point(41, 157);
            this.refferalTime_cb.Name = "refferalTime_cb";
            this.refferalTime_cb.Size = new System.Drawing.Size(192, 21);
            this.refferalTime_cb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Izaberite uput";
            // 
            // refferalSelect_cb
            // 
            this.refferalSelect_cb.FormattingEnabled = true;
            this.refferalSelect_cb.Location = new System.Drawing.Point(41, 38);
            this.refferalSelect_cb.Name = "refferalSelect_cb";
            this.refferalSelect_cb.Size = new System.Drawing.Size(192, 21);
            this.refferalSelect_cb.TabIndex = 5;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(66, 220);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(148, 39);
            this.confirm_btn.TabIndex = 6;
            this.confirm_btn.Text = "Zakazi";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // CreateCheckupFromRefferalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 289);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.refferalSelect_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refferalTime_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refferedCheckup_date);
            this.Controls.Add(this.label1);
            this.Name = "CreateCheckupFromRefferalForm";
            this.Text = "CreateCheckupFromRefferalForm";
            this.Load += new System.EventHandler(this.CreateCheckupFromRefferalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker refferedCheckup_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox refferalTime_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox refferalSelect_cb;
        private System.Windows.Forms.Button confirm_btn;
    }
}