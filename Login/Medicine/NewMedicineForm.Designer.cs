
namespace Login.ManagerRepository.GUI
{
    partial class NewMedicineForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.CheckedListBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of tablets:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(80, 221);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 26);
            this.numTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pick out the ingredients";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.Location = new System.Drawing.Point(403, 130);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(178, 96);
            this.ingredientsListBox.TabIndex = 6;
            this.ingredientsListBox.SelectedIndexChanged += new System.EventHandler(this.ingredientsListBox_SelectedIndexChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(342, 330);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(121, 52);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // NewMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMedicineForm";
            this.Text = "NewMedicineForm";
            this.Load += new System.EventHandler(this.NewMedicineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ingredientsListBox;
        private System.Windows.Forms.Button confirmBtn;
    }
}