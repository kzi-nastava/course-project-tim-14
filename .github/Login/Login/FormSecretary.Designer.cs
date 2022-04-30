
namespace Login
{
    partial class FormSecretary
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
            this.createPatientAccount_btn = new System.Windows.Forms.Button();
            this.editPatientAccount_btn = new System.Windows.Forms.Button();
            this.deletePatientAccount_btn = new System.Windows.Forms.Button();
            this.showPatients_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPatientAccount_btn
            // 
            this.createPatientAccount_btn.Location = new System.Drawing.Point(48, 132);
            this.createPatientAccount_btn.Name = "createPatientAccount_btn";
            this.createPatientAccount_btn.Size = new System.Drawing.Size(192, 62);
            this.createPatientAccount_btn.TabIndex = 0;
            this.createPatientAccount_btn.Text = "Pravljenje novog naloga za pacijenta";
            this.createPatientAccount_btn.UseVisualStyleBackColor = true;
            this.createPatientAccount_btn.Click += new System.EventHandler(this.createPatientAccount_btn_Click);
            // 
            // editPatientAccount_btn
            // 
            this.editPatientAccount_btn.Location = new System.Drawing.Point(48, 226);
            this.editPatientAccount_btn.Name = "editPatientAccount_btn";
            this.editPatientAccount_btn.Size = new System.Drawing.Size(192, 62);
            this.editPatientAccount_btn.TabIndex = 1;
            this.editPatientAccount_btn.Text = "Izmena naloga pacijenta";
            this.editPatientAccount_btn.UseVisualStyleBackColor = true;
            this.editPatientAccount_btn.Click += new System.EventHandler(this.editPatientAccount_btn_Click);
            // 
            // deletePatientAccount_btn
            // 
            this.deletePatientAccount_btn.Location = new System.Drawing.Point(48, 318);
            this.deletePatientAccount_btn.Name = "deletePatientAccount_btn";
            this.deletePatientAccount_btn.Size = new System.Drawing.Size(192, 62);
            this.deletePatientAccount_btn.TabIndex = 2;
            this.deletePatientAccount_btn.Text = "Brisanje naloga pacijenta";
            this.deletePatientAccount_btn.UseVisualStyleBackColor = true;
            this.deletePatientAccount_btn.Click += new System.EventHandler(this.deletePatientAccount_btn_Click);
            // 
            // showPatients_btn
            // 
            this.showPatients_btn.Location = new System.Drawing.Point(48, 44);
            this.showPatients_btn.Name = "showPatients_btn";
            this.showPatients_btn.Size = new System.Drawing.Size(192, 62);
            this.showPatients_btn.TabIndex = 3;
            this.showPatients_btn.Text = "Prikaz svih pacijenata";
            this.showPatients_btn.UseVisualStyleBackColor = true;
            this.showPatients_btn.Click += new System.EventHandler(this.showPatients_btn_Click);
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 419);
            this.Controls.Add(this.showPatients_btn);
            this.Controls.Add(this.deletePatientAccount_btn);
            this.Controls.Add(this.editPatientAccount_btn);
            this.Controls.Add(this.createPatientAccount_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSecretary";
            this.Text = "FormSecretary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPatientAccount_btn;
        private System.Windows.Forms.Button editPatientAccount_btn;
        private System.Windows.Forms.Button deletePatientAccount_btn;
        private System.Windows.Forms.Button showPatients_btn;
    }
}