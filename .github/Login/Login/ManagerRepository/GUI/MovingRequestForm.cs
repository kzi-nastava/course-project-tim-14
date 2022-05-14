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
    public partial class MovingRequestForm : Form
    {
        readonly EquipmentRepository equipmentRepository;
        readonly MovingRequestsRepository movingRequestsRepository;

        public MovingRequestForm(EquipmentRepository equipmentRepository, MovingRequestsRepository movingRequestsRepository)
        {
            InitializeComponent();
            this.equipmentRepository = equipmentRepository;
            this.movingRequestsRepository = movingRequestsRepository;

        }


        private void btnConfirmRequest_Click(object sender, EventArgs e)
        {
            DateTime pickedDate = movingDatePicker.Value.Date + timePicker.Value.TimeOfDay;
            int roomId = Int32.Parse(roomIdBox.Text);
            int eqId = Int32.Parse(equipmentIdBox.Text);
            int lastRequestId = movingRequestsRepository.lastId;
            movingRequestsRepository.lastId =+ 1;
            MovingRequest movingRequest = new MovingRequest(lastRequestId+1, roomId, eqId, pickedDate);
            movingRequestsRepository.WriteRequest(movingRequest);
            
        }

        private void MovingRequestForm_Load(object sender, EventArgs e)
        {
            movingDatePicker.MinDate = DateTime.Today;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;

        }

        private void movingDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
