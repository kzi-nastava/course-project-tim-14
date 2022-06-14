
namespace Login
{
    partial class FormReadCheckups
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
            this.CheckupTable = new System.Windows.Forms.DataGridView();
            this.rate_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckupTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckupTable
            // 
            this.CheckupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckupTable.Location = new System.Drawing.Point(109, 70);
            this.CheckupTable.Name = "CheckupTable";
            this.CheckupTable.RowHeadersWidth = 62;
            this.CheckupTable.RowTemplate.Height = 28;
            this.CheckupTable.Size = new System.Drawing.Size(537, 268);
            this.CheckupTable.TabIndex = 0;
            // 
            // rate_btn
            // 
            this.rate_btn.Location = new System.Drawing.Point(308, 369);
            this.rate_btn.Name = "rate_btn";
            this.rate_btn.Size = new System.Drawing.Size(139, 44);
            this.rate_btn.TabIndex = 1;
            this.rate_btn.Text = "Oceni doktora";
            this.rate_btn.UseVisualStyleBackColor = true;
            this.rate_btn.Click += new System.EventHandler(this.rate_btn_Click);
            // 
            // FormReadCheckups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rate_btn);
            this.Controls.Add(this.CheckupTable);
            this.Name = "FormReadCheckups";
            this.Text = "FormReadCheckups";
            this.Load += new System.EventHandler(this.FormReadCheckups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckupTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CheckupTable;
        private System.Windows.Forms.Button rate_btn;
    }
}