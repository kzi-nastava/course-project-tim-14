
namespace Login
{
    partial class FormUpdateCheckup
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
            this.update_cb = new System.Windows.Forms.ComboBox();
            this.update_lbl = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.time_cb = new System.Windows.Forms.ComboBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_cb
            // 
            this.update_cb.FormattingEnabled = true;
            this.update_cb.Location = new System.Drawing.Point(263, 111);
            this.update_cb.Name = "update_cb";
            this.update_cb.Size = new System.Drawing.Size(121, 28);
            this.update_cb.TabIndex = 0;
            this.update_cb.SelectedIndexChanged += new System.EventHandler(this.update_cb_SelectedIndexChanged);
            // 
            // update_lbl
            // 
            this.update_lbl.AutoSize = true;
            this.update_lbl.Location = new System.Drawing.Point(99, 111);
            this.update_lbl.Name = "update_lbl";
            this.update_lbl.Size = new System.Drawing.Size(158, 20);
            this.update_lbl.TabIndex = 1;
            this.update_lbl.Text = "Izaberite ID pregleda";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(190, 272);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(103, 37);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Izaberi";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // time_cb
            // 
            this.time_cb.FormattingEnabled = true;
            this.time_cb.Location = new System.Drawing.Point(263, 167);
            this.time_cb.Name = "time_cb";
            this.time_cb.Size = new System.Drawing.Size(121, 28);
            this.time_cb.TabIndex = 3;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(99, 170);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(158, 20);
            this.time_lbl.TabIndex = 4;
            this.time_lbl.Text = "Novo vreme pregleda";
            // 
            // FormUpdateCheckup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 367);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.time_cb);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.update_lbl);
            this.Controls.Add(this.update_cb);
            this.Name = "FormUpdateCheckup";
            this.Text = "FormUpdateCheckup";
            this.Load += new System.EventHandler(this.FormUpdateCheckup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox update_cb;
        private System.Windows.Forms.Label update_lbl;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox time_cb;
        private System.Windows.Forms.Label time_lbl;
    }
}