
namespace Login.ManagerRepository.GUI
{
    partial class ViewEquipmentForm
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
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.btnFilterByType = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilterByQuantity = new System.Windows.Forms.Button();
            this.FilterByRoom = new System.Windows.Forms.Button();
            this.equipmentTypeOptions = new System.Windows.Forms.ComboBox();
            this.quantityOptions = new System.Windows.Forms.ComboBox();
            this.roomTypeOptions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.RowHeadersWidth = 62;
            this.dataGridViewEquipment.RowTemplate.Height = 28;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(589, 438);
            this.dataGridViewEquipment.TabIndex = 0;
            // 
            // btnFilterByType
            // 
            this.btnFilterByType.Location = new System.Drawing.Point(623, 188);
            this.btnFilterByType.Name = "btnFilterByType";
            this.btnFilterByType.Size = new System.Drawing.Size(124, 46);
            this.btnFilterByType.TabIndex = 1;
            this.btnFilterByType.Text = "Filter by type";
            this.btnFilterByType.UseVisualStyleBackColor = true;
            this.btnFilterByType.Click += new System.EventHandler(this.btnFilterByType_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(623, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(124, 26);
            this.textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search equipment:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilterByQuantity
            // 
            this.btnFilterByQuantity.Location = new System.Drawing.Point(623, 285);
            this.btnFilterByQuantity.Name = "btnFilterByQuantity";
            this.btnFilterByQuantity.Size = new System.Drawing.Size(124, 52);
            this.btnFilterByQuantity.TabIndex = 5;
            this.btnFilterByQuantity.Text = "Filter by quantity";
            this.btnFilterByQuantity.UseVisualStyleBackColor = true;
            this.btnFilterByQuantity.Click += new System.EventHandler(this.btnFilterByQuantity_Click);
            // 
            // FilterByRoom
            // 
            this.FilterByRoom.Location = new System.Drawing.Point(623, 391);
            this.FilterByRoom.Name = "FilterByRoom";
            this.FilterByRoom.Size = new System.Drawing.Size(124, 43);
            this.FilterByRoom.TabIndex = 6;
            this.FilterByRoom.Text = "Filter by room";
            this.FilterByRoom.UseVisualStyleBackColor = true;
            this.FilterByRoom.Click += new System.EventHandler(this.FilterByRoom_Click);
            // 
            // equipmentTypeOptions
            // 
            this.equipmentTypeOptions.FormattingEnabled = true;
            this.equipmentTypeOptions.Items.AddRange(new object[] {
            "OperatingEquipment",
            "ExaminationEquipment",
            "HallwayEquipment",
            "RoomEquipment"});
            this.equipmentTypeOptions.Location = new System.Drawing.Point(623, 148);
            this.equipmentTypeOptions.Name = "equipmentTypeOptions";
            this.equipmentTypeOptions.Size = new System.Drawing.Size(121, 28);
            this.equipmentTypeOptions.TabIndex = 7;
            // 
            // quantityOptions
            // 
            this.quantityOptions.FormattingEnabled = true;
            this.quantityOptions.Items.AddRange(new object[] {
            "nema na stanju",
            "0-10",
            "10+"});
            this.quantityOptions.Location = new System.Drawing.Point(626, 247);
            this.quantityOptions.Name = "quantityOptions";
            this.quantityOptions.Size = new System.Drawing.Size(121, 28);
            this.quantityOptions.TabIndex = 8;
            // 
            // roomTypeOptions
            // 
            this.roomTypeOptions.FormattingEnabled = true;
            this.roomTypeOptions.Items.AddRange(new object[] {
            "Warehouse",
            "OperatingRoom",
            "BreakRoom",
            "ExaminationRoom"});
            this.roomTypeOptions.Location = new System.Drawing.Point(624, 350);
            this.roomTypeOptions.Name = "roomTypeOptions";
            this.roomTypeOptions.Size = new System.Drawing.Size(121, 28);
            this.roomTypeOptions.TabIndex = 9;
            // 
            // ViewEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomTypeOptions);
            this.Controls.Add(this.quantityOptions);
            this.Controls.Add(this.equipmentTypeOptions);
            this.Controls.Add(this.FilterByRoom);
            this.Controls.Add(this.btnFilterByQuantity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnFilterByType);
            this.Controls.Add(this.dataGridViewEquipment);
            this.Name = "ViewEquipmentForm";
            this.Text = "ViewEquipmentForm";
            this.Load += new System.EventHandler(this.ViewEquipmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button btnFilterByType;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilterByQuantity;
        private System.Windows.Forms.Button FilterByRoom;
        private System.Windows.Forms.ComboBox equipmentTypeOptions;
        private System.Windows.Forms.ComboBox quantityOptions;
        private System.Windows.Forms.ComboBox roomTypeOptions;
    }
}