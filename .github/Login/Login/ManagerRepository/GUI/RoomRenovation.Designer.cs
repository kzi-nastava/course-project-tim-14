
namespace Login.ManagerRepository.GUI
{
    partial class RoomRenovation
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
            this.roomIdBox = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.confirmRenovation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Room id:";
            // 
            // roomIdBox
            // 
            this.roomIdBox.Location = new System.Drawing.Point(295, 99);
            this.roomIdBox.Name = "roomIdBox";
            this.roomIdBox.Size = new System.Drawing.Size(138, 26);
            this.roomIdBox.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(53, 256);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 26);
            this.startDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Renovation starts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Renovation ends:";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(472, 256);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 26);
            this.endDate.TabIndex = 5;
            // 
            // confirmRenovation
            // 
            this.confirmRenovation.Location = new System.Drawing.Point(295, 348);
            this.confirmRenovation.Name = "confirmRenovation";
            this.confirmRenovation.Size = new System.Drawing.Size(138, 41);
            this.confirmRenovation.TabIndex = 6;
            this.confirmRenovation.Text = "Confirm";
            this.confirmRenovation.UseVisualStyleBackColor = true;
            this.confirmRenovation.Click += new System.EventHandler(this.confirmRenovation_Click);
            // 
            // RoomRenovation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmRenovation);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.roomIdBox);
            this.Controls.Add(this.label1);
            this.Name = "RoomRenovation";
            this.Text = "RoomRenovation";
            this.Load += new System.EventHandler(this.RoomRenovation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomIdBox;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button confirmRenovation;
    }
}