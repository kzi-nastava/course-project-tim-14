using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class Equipment
    {
		public enum Type
		{
			OperatingEquipment,
			ExaminationEquipment,
			RoomEquipment,
			HallwayEquipment
		}

		public string type;
		public string description;
		public int id;
        public string name;
        public string roomType;
        public int roomId;

        public Equipment(int id, string type, string description, string name, string roomType, int roomId)
        {
			this.id = id;
			this.type = type;
            this.description = description;
			this.name = name;
			this.roomType = roomType;
			this.roomId = roomId;
        }

		public string ToFile()
		{
			return id.ToString() + "|" + type + "|" + description + "|" + name + "|" + roomType + "|" + roomId.ToString();
		}
	}
}
