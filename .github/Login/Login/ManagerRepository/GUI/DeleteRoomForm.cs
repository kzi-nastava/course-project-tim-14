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
    public partial class DeleteRoomForm : Form
    {
        readonly RoomsRepository roomsRepository;

        public DeleteRoomForm(RoomsRepository roomsRepository)
        {
            InitializeComponent();
            this.roomsRepository = roomsRepository;

        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            int choosenId = Int32.Parse(textBoxId.Text);
            if (choosenId != 0)
            {
                Room room = roomsRepository.FindRoom(choosenId);
                if (room != null)
                {
                    roomsRepository.rooms.Remove(room);
                    roomsRepository.ReloadRoomRepository();
                }
            }
        }
    }
}
