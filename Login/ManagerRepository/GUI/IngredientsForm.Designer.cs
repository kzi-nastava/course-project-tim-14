
namespace Login.ManagerRepository.GUI
{
    partial class IngredientsForm
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
            this.ingredientsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientsGridView
            // 
            this.ingredientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsGridView.Location = new System.Drawing.Point(0, 0);
            this.ingredientsGridView.Name = "ingredientsGridView";
            this.ingredientsGridView.RowHeadersWidth = 62;
            this.ingredientsGridView.RowTemplate.Height = 28;
            this.ingredientsGridView.Size = new System.Drawing.Size(555, 464);
            this.ingredientsGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New Ingredient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Ingredients";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Ingredient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ingredientsGridView);
            this.Name = "IngredientsForm";
            this.Text = "IngredientsForm";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ingredientsGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}