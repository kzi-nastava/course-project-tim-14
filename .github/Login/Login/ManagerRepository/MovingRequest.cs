using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class MovingRequest
    {
        public int id;
        public int roomId;
        public int equipmentId;
        public DateTime movingTime;

        public MovingRequest(int id, int roomId, int eqId, DateTime pickedDate)
        {
            this.id = id;
            this.roomId = roomId;
            this.equipmentId = eqId;
            this.movingTime = pickedDate;
        }

        public string ToFile()
        {
            return id.ToString() + "|" + roomId.ToString() + "|" + equipmentId.ToString() + "|" + movingTime.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
