﻿
namespace Login.ManagerRepository.GUI
{
    partial class DeleteIngredientForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the ingredient id that you wanna delete";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(330, 206);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(107, 26);
            this.idTextBox.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(330, 302);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 47);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DeleteIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteIngredientForm";
            this.Text = "DeleteIngredientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}