
namespace Login.ManagerRepository.GUI
{
    partial class ShowRoomsForm
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
            this.roomsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsGridView
            // 
            this.roomsGridView.AllowUserToAddRows = false;
            this.roomsGridView.AllowUserToDeleteRows = false;
            this.roomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsGridView.Location = new System.Drawing.Point(0, 0);
            this.roomsGridView.Name = "roomsGridView";
            this.roomsGridView.ReadOnly = true;
            this.roomsGridView.RowHeadersWidth = 62;
            this.roomsGridView.RowTemplate.Height = 28;
            this.roomsGridView.Size = new System.Drawing.Size(576, 312);
            this.roomsGridView.TabIndex = 0;
            // 
            // ShowRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomsGridView);
            this.Name = "ShowRoomsForm";
            this.Text = "ShowRoomsForm";
            this.Load += new System.EventHandler(this.ShowRoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomsGridView;
    }
}