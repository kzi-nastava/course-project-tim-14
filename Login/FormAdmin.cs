using Login.ManagerRepository;
using Login.ManagerRepository.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormAdmin : Form

    {
        public RoomsRepository roomsRepository;
        public EquipmentRepository equipmentRepository;
        public MovingRequestsRepository movingRequestsRepository;
        public MedicineRepository medicineRepository;
        public IngredientRepository ingredientRepository;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            var newRoomForm = new Manager.NewRoomForm(roomsRepository);
            newRoomForm.Show();
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            var showRoomForm = new ShowRoomsForm(roomsRepository);
            showRoomForm.Show();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            var updateRoomForm = new UpdateRoomForm(roomsRepository);
            updateRoomForm.Show();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            var deleteRoomForm = new DeleteRoomForm(roomsRepository);
            deleteRoomForm.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewEquipmentForm viewEquipmentForm = new ViewEquipmentForm(equipmentRepository);
            viewEquipmentForm.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MovingRequestForm movingRequestForm = new MovingRequestForm(equipmentRepository, movingRequestsRepository);
            movingRequestForm.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            roomsRepository = new RoomsRepository();
            roomsRepository.LoadRoomRepository();
            equipmentRepository = new EquipmentRepository();
            equipmentRepository.LoadEquipmentRepository();
            //movingRequestsRepository = new MovingRequestsRepository(equipmentRepository, roomsRepository);
            //movingRequestsRepository.LoadMovingRequestsRepository();
            ingredientRepository = new IngredientRepository();
            ingredientRepository.LoadRepository();
            medicineRepository = new MedicineRepository();
            medicineRepository.LoadRepository();
        }

        private void ViewIngredientsBtn_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredientsForm = new IngredientsForm(ingredientRepository);
            ingredientsForm.Show();
        }

        private void newMedicineBtn_Click(object sender, EventArgs e)
        {
            NewMedicineForm newMedicineForm = new NewMedicineForm(medicineRepository, ingredientRepository);
            newMedicineForm.Show();
        }

        private void rejectedBtn_Click(object sender, EventArgs e)
        {
            RejectedMedicineForm rejectedMedicineForm = new RejectedMedicineForm(medicineRepository, ingredientRepository);
            rejectedMedicineForm.Show();
        }
    }
}
