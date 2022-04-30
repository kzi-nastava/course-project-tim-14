using Login.ManagerRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Manager
{
    public partial class NewRoomForm : Form
    {
        readonly RoomsRepository roomsRepository;

        public NewRoomForm(RoomsRepository roomsRepository)
        {
            InitializeComponent();
            this.roomsRepository = roomsRepository;

        }

        private void btnConfirmNewRoom_Click(object sender, EventArgs e)
        {
            string selectedType = typeOptions.SelectedItem.ToString();
            int newId = roomsRepository.rooms.Last().id;
            Room createdRoom = new Room(newId+1, selectedType);
            roomsRepository.AddNewRoom(createdRoom);

            MessageBox.Show("New room created.", "Success");
            this.Close();
        }

    }
}
