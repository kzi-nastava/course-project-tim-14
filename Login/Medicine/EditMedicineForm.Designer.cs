
namespace Login.ManagerRepository.GUI
{
    partial class EditMedicineForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.CheckedListBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of tablets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the id:";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.Location = new System.Drawing.Point(297, 237);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(198, 119);
            this.ingredientsListBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(39, 89);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(49, 241);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(632, 260);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(141, 56);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(227, 61);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(138, 51);
            this.findBtn.TabIndex = 7;
            this.findBtn.Text = "Find Medicine";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(51, 335);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 26);
            this.numTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingredients:";
            // 
            // EditMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMedicineForm";
            this.Text = "EditMedicineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ingredientsListBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label label4;
    }
}