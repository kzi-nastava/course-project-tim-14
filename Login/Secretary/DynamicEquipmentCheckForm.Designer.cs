
namespace Login.Secretary
{
    partial class DynamicEquipmentCheckForm
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
            this.selectedEquipment_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentQtt_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createRequest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedEquipment_cb
            // 
            this.selectedEquipment_cb.FormattingEnabled = true;
            this.selectedEquipment_cb.Location = new System.Drawing.Point(66, 65);
            this.selectedEquipment_cb.Name = "selectedEquipment_cb";
            this.selectedEquipment_cb.Size = new System.Drawing.Size(295, 24);
            this.selectedEquipment_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dinamcika oprema koje nema na stanju";
            // 
            // equipmentQtt_tb
            // 
            this.equipmentQtt_tb.Location = new System.Drawing.Point(66, 175);
            this.equipmentQtt_tb.Name = "equipmentQtt_tb";
            this.equipmentQtt_tb.Size = new System.Drawing.Size(295, 22);
            this.equipmentQtt_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolicina izabrane opreme za narucivanje";
            // 
            // createRequest_btn
            // 
            this.createRequest_btn.Location = new System.Drawing.Point(120, 272);
            this.createRequest_btn.Name = "createRequest_btn";
            this.createRequest_btn.Size = new System.Drawing.Size(188, 53);
            this.createRequest_btn.TabIndex = 4;
            this.createRequest_btn.Text = "Kreiraj zahtev";
            this.createRequest_btn.UseVisualStyleBackColor = true;
            this.createRequest_btn.Click += new System.EventHandler(this.createRequest_btn_Click);
            // 
            // DynamicEquipmentCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 416);
            this.Controls.Add(this.createRequest_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipmentQtt_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedEquipment_cb);
            this.Name = "DynamicEquipmentCheckForm";
            this.Text = "DynamicEquipmentCheckForm";
            this.Load += new System.EventHandler(this.DynamicEquipmentCheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedEquipment_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equipmentQtt_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createRequest_btn;
    }
}