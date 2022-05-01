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
    public partial class ShowRoomsForm : Form
    {
        readonly RoomsRepository roomsRepository;
        public ShowRoomsForm(RoomsRepository roomsRepository)
        {
            InitializeComponent();
            this.roomsRepository = roomsRepository;

        }

        private void ShowRoomsForm_Load(object sender, EventArgs e)
        {
            DataTable roomTable = new DataTable();
            roomTable.Columns.Add("ROOM ID");
            roomTable.Columns.Add("ROOM TYPE");
            foreach (Room room in roomsRepository.rooms)
            {
                roomTable.Rows.Add(room.id, room.type);
            }
            roomsGridView.DataSource = roomTable;
        }

    }
}
