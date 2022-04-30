
namespace Login
{
    partial class FormDeleteCheckup
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
            this.delete_cb = new System.Windows.Forms.ComboBox();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_cb
            // 
            this.delete_cb.FormattingEnabled = true;
            this.delete_cb.Location = new System.Drawing.Point(226, 84);
            this.delete_cb.Name = "delete_cb";
            this.delete_cb.Size = new System.Drawing.Size(121, 28);
            this.delete_cb.TabIndex = 0;
            // 
            // delete_lbl
            // 
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Location = new System.Drawing.Point(38, 87);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(162, 20);
            this.delete_lbl.TabIndex = 1;
            this.delete_lbl.Text = "Izaberite ID pregleda:";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(155, 296);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(103, 29);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Obrisi";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // FormDeleteCheckup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 372);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.delete_lbl);
            this.Controls.Add(this.delete_cb);
            this.Name = "FormDeleteCheckup";
            this.Text = "FormDeleteCheckup";
            this.Load += new System.EventHandler(this.FormDeleteCheckup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delete_cb;
        private System.Windows.Forms.Label delete_lbl;
        private System.Windows.Forms.Button delete_btn;
    }
}