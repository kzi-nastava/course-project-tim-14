
namespace Login.ManagerRepository.GUI
{
    partial class UpdateRoomForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.typeOptions = new System.Windows.Forms.ComboBox();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(311, 116);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(131, 26);
            this.textBoxId.TabIndex = 0;
            // 
            // typeOptions
            // 
            this.typeOptions.FormattingEnabled = true;
            this.typeOptions.Items.AddRange(new object[] {
            "Operating Room",
            "Examination Room",
            "Break Room"});
            this.typeOptions.Location = new System.Drawing.Point(301, 218);
            this.typeOptions.Name = "typeOptions";
            this.typeOptions.Size = new System.Drawing.Size(168, 28);
            this.typeOptions.TabIndex = 1;
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Location = new System.Drawing.Point(301, 300);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(164, 51);
            this.btnConfirmChanges.TabIndex = 2;
            this.btnConfirmChanges.Text = "Confirm changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the room id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose what kind of room";
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.typeOptions);
            this.Controls.Add(this.textBoxId);
            this.Name = "UpdateRoom";
            this.Text = "UpdateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox typeOptions;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}