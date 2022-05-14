using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.ManagerRepository
{
    public class MovingRequestsRepository
    {
        public List<MovingRequest> movingRequests = new List<MovingRequest>();
        public string requestsFileName = "../../Data/movingRequest.txt";
        public int lastId;
        readonly EquipmentRepository equipmentRepository;
        readonly RoomsRepository roomsRepository;

        public MovingRequestsRepository(EquipmentRepository equipmentRepository, RoomsRepository roomsRepository)
        {
            this.equipmentRepository = equipmentRepository;
            this.roomsRepository = roomsRepository;
        }

        public MovingRequestsRepository()
        {
        }

        public void LoadMovingRequestsRepository()
        {
            string[] lines = File.ReadAllLines(requestsFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                var cultureInfo = new CultureInfo("de-DE");
                string dateString = data[3];
                var movingDate = DateTime.Parse(dateString, cultureInfo);

                this.lastId = Int32.Parse(data[0]);

                MovingRequest movingRequest = new MovingRequest(lastId, Int32.Parse(data[1]), Int32.Parse(data[2]), movingDate);

                if (DateTime.Compare(movingDate, DateTime.Today) <= 0)
                {

                    moveEquipment(movingRequest);
                } else
                {
                    movingRequests.Add(movingRequest);
                }
            }
        }

        public void WriteRequest(MovingRequest movingRequest)
        {
            using (StreamWriter tw = File.AppendText(requestsFileName))
            {
                tw.WriteLine(movingRequest.ToFile());
                tw.Close();
            }
        }

        public void moveEquipment(MovingRequest movingRequest)
        {
            Equipment eq = equipmentRepository.FindById(movingRequest.equipmentId);
            eq.roomId = movingRequest.roomId;

            Room room = roomsRepository.FindRoom(movingRequest.roomId);


            eq.roomType = room.type;


            equipmentRepository.ReloadEquipmentRepository();
        }
    }
}
