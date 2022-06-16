
namespace Login.ManagerRepository.GUI
{
    partial class RejectedMedicineForm
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
            this.medicineGridView = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicineGridView
            // 
            this.medicineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineGridView.Location = new System.Drawing.Point(0, 0);
            this.medicineGridView.Name = "medicineGridView";
            this.medicineGridView.RowHeadersWidth = 62;
            this.medicineGridView.RowTemplate.Height = 28;
            this.medicineGridView.Size = new System.Drawing.Size(553, 451);
            this.medicineGridView.TabIndex = 0;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(610, 132);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(126, 45);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit Medicine";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // RejectedMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.medicineGridView);
            this.Name = "RejectedMedicineForm";
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.RejectedMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView medicineGridView;
        private System.Windows.Forms.Button editBtn;
    }
}