using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.ManagerRepository.GUI
{
    public partial class UpdateRoomForm : Form
    {
        readonly RoomsRepository roomsRepository;

        public UpdateRoomForm(RoomsRepository roomsRepository)
        {
            InitializeComponent();
            this.roomsRepository = roomsRepository;

        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            int choosenId = Int32.Parse(textBoxId.Text);
            int index = roomsRepository.FindRoomIndex(choosenId);
            if (index != -1)
            {
                roomsRepository.rooms[index].type = typeOptions.SelectedItem.ToString();
                roomsRepository.ReloadRoomRepository();
            }
        }
    }
}
