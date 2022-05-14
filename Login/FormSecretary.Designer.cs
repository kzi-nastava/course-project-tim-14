
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
            this.viewSingleAccount_btn = new System.Windows.Forms.Button();
            this.showBlockedAccounts_btn = new System.Windows.Forms.Button();
            this.requestCheck_btn = new System.Windows.Forms.Button();
            this.createCheckupFromRefferal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPatientAccount_btn
            // 
            this.createPatientAccount_btn.Location = new System.Drawing.Point(226, 36);
            this.createPatientAccount_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createPatientAccount_btn.Name = "createPatientAccount_btn";
            this.createPatientAccount_btn.Size = new System.Drawing.Size(144, 50);
            this.createPatientAccount_btn.TabIndex = 0;
            this.createPatientAccount_btn.Text = "Pravljenje novog naloga za pacijenta";
            this.createPatientAccount_btn.UseVisualStyleBackColor = true;
            this.createPatientAccount_btn.Click += new System.EventHandler(this.createPatientAccount_btn_Click);
            // 
            // editPatientAccount_btn
            // 
            this.editPatientAccount_btn.Location = new System.Drawing.Point(226, 115);
            this.editPatientAccount_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editPatientAccount_btn.Name = "editPatientAccount_btn";
            this.editPatientAccount_btn.Size = new System.Drawing.Size(144, 50);
            this.editPatientAccount_btn.TabIndex = 1;
            this.editPatientAccount_btn.Text = "Izmena naloga pacijenta";
            this.editPatientAccount_btn.UseVisualStyleBackColor = true;
            this.editPatientAccount_btn.Click += new System.EventHandler(this.editPatientAccount_btn_Click);
            // 
            // deletePatientAccount_btn
            // 
            this.deletePatientAccount_btn.Location = new System.Drawing.Point(226, 206);
            this.deletePatientAccount_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePatientAccount_btn.Name = "deletePatientAccount_btn";
            this.deletePatientAccount_btn.Size = new System.Drawing.Size(144, 50);
            this.deletePatientAccount_btn.TabIndex = 2;
            this.deletePatientAccount_btn.Text = "Brisanje naloga pacijenta";
            this.deletePatientAccount_btn.UseVisualStyleBackColor = true;
            this.deletePatientAccount_btn.Click += new System.EventHandler(this.deletePatientAccount_btn_Click);
            // 
            // showPatients_btn
            // 
            this.showPatients_btn.Location = new System.Drawing.Point(36, 36);
            this.showPatients_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPatients_btn.Name = "showPatients_btn";
            this.showPatients_btn.Size = new System.Drawing.Size(144, 50);
            this.showPatients_btn.TabIndex = 3;
            this.showPatients_btn.Text = "Prikaz svih pacijenata";
            this.showPatients_btn.UseVisualStyleBackColor = true;
            this.showPatients_btn.Click += new System.EventHandler(this.showPatients_btn_Click);
            // 
            // viewSingleAccount_btn
            // 
            this.viewSingleAccount_btn.Location = new System.Drawing.Point(36, 115);
            this.viewSingleAccount_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewSingleAccount_btn.Name = "viewSingleAccount_btn";
            this.viewSingleAccount_btn.Size = new System.Drawing.Size(144, 50);
            this.viewSingleAccount_btn.TabIndex = 4;
            this.viewSingleAccount_btn.Text = "Pregled pojedinacnih naloga pacijenata";
            this.viewSingleAccount_btn.UseVisualStyleBackColor = true;
            this.viewSingleAccount_btn.Click += new System.EventHandler(this.viewSingleAccount_btn_Click);
            // 
            // showBlockedAccounts_btn
            // 
            this.showBlockedAccounts_btn.Location = new System.Drawing.Point(36, 206);
            this.showBlockedAccounts_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showBlockedAccounts_btn.Name = "showBlockedAccounts_btn";
            this.showBlockedAccounts_btn.Size = new System.Drawing.Size(144, 50);
            this.showBlockedAccounts_btn.TabIndex = 5;
            this.showBlockedAccounts_btn.Text = "Pregled blokiranih naloga";
            this.showBlockedAccounts_btn.UseVisualStyleBackColor = true;
            this.showBlockedAccounts_btn.Click += new System.EventHandler(this.showBlockedAccounts_btn_Click);
            // 
            // requestCheck_btn
            // 
            this.requestCheck_btn.Location = new System.Drawing.Point(36, 291);
            this.requestCheck_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requestCheck_btn.Name = "requestCheck_btn";
            this.requestCheck_btn.Size = new System.Drawing.Size(144, 50);
            this.requestCheck_btn.TabIndex = 6;
            this.requestCheck_btn.Text = "Pregled zahteva";
            this.requestCheck_btn.UseVisualStyleBackColor = true;
            this.requestCheck_btn.Click += new System.EventHandler(this.requestCheck_btn_Click);
            // 
            // createCheckupFromRefferal_btn
            // 
            this.createCheckupFromRefferal_btn.Location = new System.Drawing.Point(513, 36);
            this.createCheckupFromRefferal_btn.Name = "createCheckupFromRefferal_btn";
            this.createCheckupFromRefferal_btn.Size = new System.Drawing.Size(144, 50);
            this.createCheckupFromRefferal_btn.TabIndex = 7;
            this.createCheckupFromRefferal_btn.Text = "Zakazivanje pregleda preko uputa";
            this.createCheckupFromRefferal_btn.UseVisualStyleBackColor = true;
            this.createCheckupFromRefferal_btn.Click += new System.EventHandler(this.createCheckupFromRefferal_btn_Click);
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 360);
            this.Controls.Add(this.createCheckupFromRefferal_btn);
            this.Controls.Add(this.requestCheck_btn);
            this.Controls.Add(this.showBlockedAccounts_btn);
            this.Controls.Add(this.viewSingleAccount_btn);
            this.Controls.Add(this.showPatients_btn);
            this.Controls.Add(this.deletePatientAccount_btn);
            this.Controls.Add(this.editPatientAccount_btn);
            this.Controls.Add(this.createPatientAccount_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSecretary";
            this.Text = "FormSecretary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPatientAccount_btn;
        private System.Windows.Forms.Button editPatientAccount_btn;
        private System.Windows.Forms.Button deletePatientAccount_btn;
        private System.Windows.Forms.Button showPatients_btn;
        private System.Windows.Forms.Button viewSingleAccount_btn;
        private System.Windows.Forms.Button showBlockedAccounts_btn;
        private System.Windows.Forms.Button requestCheck_btn;
        private System.Windows.Forms.Button createCheckupFromRefferal_btn;
    }
}