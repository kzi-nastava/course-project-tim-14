using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class RoomsRepository
    {
        public List<Room> rooms = new List<Room>();
        public string roomsFileName = "../../Data/rooms.txt";

        public RoomsRepository()
        {
            if (!rooms.Any())
            {
                this.LoadRoomRepository();
            }
        }

        public void LoadRoomRepository()
        {
            string[] lines = File.ReadAllLines(roomsFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Room room = new Room(Int32.Parse(data[0]), data[1]);
                rooms.Add(room);
            }
        }

        public void AddNewRoom(Room createdRoom)
        {
            rooms.Add(createdRoom);
            using (StreamWriter tw = File.AppendText(roomsFileName))
            {
                tw.WriteLine(createdRoom.ToFile());
                tw.Close();
            }
        }

        public Room FindRoom(int id)
        {
            foreach (Room room in rooms)
            {
                if (room.id == id)
                {
                    return room;
                }
            }
            return null;
        }

        public int FindRoomIndex(int id)
        {
            int i = 0;
            foreach (Room room in rooms)
            {
                i++;
                if (room.id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void ReloadRoomRepository()
        {
            TextWriter tw = new StreamWriter(roomsFileName);

            foreach (Room room in rooms)
            {
                tw.WriteLine(room.ToFile());
            }
            tw.Close();
        }
    }
}
