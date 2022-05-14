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
    public partial class RoomRenovation : Form
    {
        private CheckupRepository checkupRepository;
        private RoomsRepository roomsRepository;

        public RoomRenovation(CheckupRepository checkupRepository, RoomsRepository roomsRepository)
        {
            InitializeComponent();
            this.checkupRepository = checkupRepository;
            this.roomsRepository = roomsRepository;
        }

        private void confirmRenovation_Click(object sender, EventArgs e)
        {
            DateTime renovationStart = startDate.Value.Date;
            DateTime renovationEnd = endDate.Value.Date;
            int validDatePicked = DateTime.Compare(renovationStart, renovationEnd);
            bool roomAvailable = true;
            Room room = roomsRepository.FindRoom(Int32.Parse(roomIdBox.Text));
            if (validDatePicked < 0)
            {
                if (room.type == "ExaminatioRoom") {
                    foreach (Checkup checkup in checkupRepository.checkups)
                    {
                        if (checkup.dateTime > renovationStart && checkup.dateTime < renovationEnd)
                        {
                            roomAvailable = false;
                            break;
                        }
                    }
                }
                if (roomAvailable) {
                    Renovation renovation = new Renovation(Int32.Parse(roomIdBox.Text), renovationStart, renovationEnd);
                    roomsRepository.WriteToFile(renovation.ToFile());
                    MessageBox.Show("Renovation confirmed.", "Success");
                }
                else
                {
                    MessageBox.Show("The room isn't available for the selected dates.", "Error");
                }
            } else
            {
                MessageBox.Show("Start date must be earlier than end date.", "Error");
            }

        }

        private void RoomRenovation_Load(object sender, EventArgs e)
        {
            startDate.MinDate = DateTime.Today;
            endDate.MinDate = DateTime.Today;
        }
    }
}
