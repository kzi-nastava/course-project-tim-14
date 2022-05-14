
namespace Login
{
    partial class FormAdmin
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
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.btnShowRooms = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.roomRenovationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Menu";
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(41, 95);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(141, 56);
            this.btnNewRoom.TabIndex = 1;
            this.btnNewRoom.Text = "Create a New Room";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // btnShowRooms
            // 
            this.btnShowRooms.Location = new System.Drawing.Point(218, 97);
            this.btnShowRooms.Name = "btnShowRooms";
            this.btnShowRooms.Size = new System.Drawing.Size(141, 53);
            this.btnShowRooms.TabIndex = 3;
            this.btnShowRooms.Text = "Show Rooms";
            this.btnShowRooms.UseVisualStyleBackColor = true;
            this.btnShowRooms.Click += new System.EventHandler(this.btnShowRooms_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(41, 191);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(141, 57);
            this.btnUpdateRoom.TabIndex = 4;
            this.btnUpdateRoom.Text = "Update Room Information";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(218, 191);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(141, 57);
            this.btnDeleteRoom.TabIndex = 5;
            this.btnDeleteRoom.Text = "Delete a Room from System";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(467, 98);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(142, 65);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View Equipment";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(467, 186);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(191, 66);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "Make a Moving Equipment Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // roomRenovationBtn
            // 
            this.roomRenovationBtn.Location = new System.Drawing.Point(132, 301);
            this.roomRenovationBtn.Name = "roomRenovationBtn";
            this.roomRenovationBtn.Size = new System.Drawing.Size(141, 53);
            this.roomRenovationBtn.TabIndex = 8;
            this.roomRenovationBtn.Text = "Plan a Room Renovation";
            this.roomRenovationBtn.UseVisualStyleBackColor = true;
            this.roomRenovationBtn.Click += new System.EventHandler(this.roomRenovationBtn_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomRenovationBtn);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnShowRooms);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Button btnShowRooms;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button roomRenovationBtn;
    }
}