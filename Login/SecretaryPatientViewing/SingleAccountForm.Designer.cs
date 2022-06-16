
namespace Login.Secretary
{
    partial class SingleAccountForm
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
            this.block_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.blockedStatus_tb = new System.Windows.Forms.TextBox();
            this.patientPassword_tb = new System.Windows.Forms.TextBox();
            this.patientEmail_tb = new System.Windows.Forms.TextBox();
            this.patientLastName_tb = new System.Windows.Forms.TextBox();
            this.patientName_tb = new System.Windows.Forms.TextBox();
            this.patientId_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // block_btn
            // 
            this.block_btn.Location = new System.Drawing.Point(50, 113);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(168, 60);
            this.block_btn.TabIndex = 0;
            this.block_btn.Text = "Blokiraj nalog";
            this.block_btn.UseVisualStyleBackColor = true;
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.54545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63636F));
            this.tableLayoutPanel1.Controls.Add(this.blockedStatus_tb, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientPassword_tb, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientEmail_tb, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientLastName_tb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientName_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientId_tb, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // blockedStatus_tb
            // 
            this.blockedStatus_tb.Location = new System.Drawing.Point(466, 3);
            this.blockedStatus_tb.Name = "blockedStatus_tb";
            this.blockedStatus_tb.Size = new System.Drawing.Size(81, 22);
            this.blockedStatus_tb.TabIndex = 0;
            // 
            // patientPassword_tb
            // 
            this.patientPassword_tb.Location = new System.Drawing.Point(364, 3);
            this.patientPassword_tb.Name = "patientPassword_tb";
            this.patientPassword_tb.Size = new System.Drawing.Size(96, 22);
            this.patientPassword_tb.TabIndex = 1;
            // 
            // patientEmail_tb
            // 
            this.patientEmail_tb.Location = new System.Drawing.Point(238, 3);
            this.patientEmail_tb.Name = "patientEmail_tb";
            this.patientEmail_tb.Size = new System.Drawing.Size(120, 22);
            this.patientEmail_tb.TabIndex = 2;
            // 
            // patientLastName_tb
            // 
            this.patientLastName_tb.Location = new System.Drawing.Point(140, 3);
            this.patientLastName_tb.Name = "patientLastName_tb";
            this.patientLastName_tb.Size = new System.Drawing.Size(92, 22);
            this.patientLastName_tb.TabIndex = 3;
            // 
            // patientName_tb
            // 
            this.patientName_tb.Location = new System.Drawing.Point(60, 3);
            this.patientName_tb.Name = "patientName_tb";
            this.patientName_tb.Size = new System.Drawing.Size(74, 22);
            this.patientName_tb.TabIndex = 4;
            // 
            // patientId_tb
            // 
            this.patientId_tb.Location = new System.Drawing.Point(3, 3);
            this.patientId_tb.Name = "patientId_tb";
            this.patientId_tb.Size = new System.Drawing.Size(51, 22);
            this.patientId_tb.TabIndex = 5;
            // 
            // SingleAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 196);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.block_btn);
            this.Name = "SingleAccountForm";
            this.Text = "SingleAccountForm";
            this.Load += new System.EventHandler(this.SingleAccountForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button block_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox blockedStatus_tb;
        private System.Windows.Forms.TextBox patientPassword_tb;
        private System.Windows.Forms.TextBox patientEmail_tb;
        private System.Windows.Forms.TextBox patientLastName_tb;
        private System.Windows.Forms.TextBox patientName_tb;
        private System.Windows.Forms.TextBox patientId_tb;
    }
}