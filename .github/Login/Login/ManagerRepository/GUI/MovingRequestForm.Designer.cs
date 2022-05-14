
namespace Login.ManagerRepository.GUI
{
    partial class MovingRequestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.roomIdBox = new System.Windows.Forms.TextBox();
            this.equipmentIdBox = new System.Windows.Forms.TextBox();
            this.movingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmRequest = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the room id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the equipment id";
            // 
            // roomIdBox
            // 
            this.roomIdBox.Location = new System.Drawing.Point(147, 90);
            this.roomIdBox.Name = "roomIdBox";
            this.roomIdBox.Size = new System.Drawing.Size(171, 26);
            this.roomIdBox.TabIndex = 2;
            // 
            // equipmentIdBox
            // 
            this.equipmentIdBox.Location = new System.Drawing.Point(466, 90);
            this.equipmentIdBox.Name = "equipmentIdBox";
            this.equipmentIdBox.Size = new System.Drawing.Size(171, 26);
            this.equipmentIdBox.TabIndex = 3;
            // 
            // movingDatePicker
            // 
            this.movingDatePicker.Location = new System.Drawing.Point(286, 215);
            this.movingDatePicker.Name = "movingDatePicker";
            this.movingDatePicker.Size = new System.Drawing.Size(200, 26);
            this.movingDatePicker.TabIndex = 4;
            this.movingDatePicker.ValueChanged += new System.EventHandler(this.movingDatePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick the date and time:";
            // 
            // btnConfirmRequest
            // 
            this.btnConfirmRequest.Location = new System.Drawing.Point(310, 339);
            this.btnConfirmRequest.Name = "btnConfirmRequest";
            this.btnConfirmRequest.Size = new System.Drawing.Size(156, 47);
            this.btnConfirmRequest.TabIndex = 6;
            this.btnConfirmRequest.Text = "Confirm";
            this.btnConfirmRequest.UseVisualStyleBackColor = true;
            this.btnConfirmRequest.Click += new System.EventHandler(this.btnConfirmRequest_Click);
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(327, 278);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(119, 26);
            this.timePicker.TabIndex = 9;
            // 
            // MovingRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnConfirmRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movingDatePicker);
            this.Controls.Add(this.equipmentIdBox);
            this.Controls.Add(this.roomIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovingRequestForm";
            this.Text = "MovingRequestForm";
            this.Load += new System.EventHandler(this.MovingRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomIdBox;
        private System.Windows.Forms.TextBox equipmentIdBox;
        private System.Windows.Forms.DateTimePicker movingDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmRequest;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}