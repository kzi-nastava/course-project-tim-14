
namespace Login.Manager
{
    partial class NewRoomForm
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
            this.btnConfirmNewRoom = new System.Windows.Forms.Button();
            this.typeOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmNewRoom
            // 
            this.btnConfirmNewRoom.Location = new System.Drawing.Point(218, 215);
            this.btnConfirmNewRoom.Name = "btnConfirmNewRoom";
            this.btnConfirmNewRoom.Size = new System.Drawing.Size(123, 51);
            this.btnConfirmNewRoom.TabIndex = 0;
            this.btnConfirmNewRoom.Text = "Confirm";
            this.btnConfirmNewRoom.UseVisualStyleBackColor = true;
            this.btnConfirmNewRoom.Click += new System.EventHandler(this.btnConfirmNewRoom_Click);
            // 
            // typeOptions
            // 
            this.typeOptions.FormattingEnabled = true;
            this.typeOptions.Items.AddRange(new object[] {
            "OperatingRoom",
            "ExaminationRoom",
            "BreakRoom"});
            this.typeOptions.Location = new System.Drawing.Point(187, 133);
            this.typeOptions.Name = "typeOptions";
            this.typeOptions.Size = new System.Drawing.Size(197, 28);
            this.typeOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose what kind of room: ";
            // 
            // NewRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeOptions);
            this.Controls.Add(this.btnConfirmNewRoom);
            this.Name = "NewRoomForm";
            this.Text = "Create a New Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmNewRoom;
        private System.Windows.Forms.ComboBox typeOptions;
        private System.Windows.Forms.Label label1;
    }
}