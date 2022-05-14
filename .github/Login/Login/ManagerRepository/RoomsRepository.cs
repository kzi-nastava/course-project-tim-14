using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class RoomsRepository
    {
        public List<Room> rooms = new List<Room>();
        public List<Renovation> currentRenovations = new List<Renovation>();
        public Dictionary<int, List<DateTime>> schedule;
        public string roomsFileName = "../../Data/rooms.txt";
        public string scheduleFileName = "../../Data/roomCheckupsSchedule.txt";
        public string renovationFileName = "../../Data/renovations.txt";

        public RoomsRepository()
        {
            if (!rooms.Any())
            {
                this.LoadRoomRepository();
                this.LoadRenovations();
                this.LoadSchedule();
            }
        }

        private void LoadSchedule()
        {
            string[] lines = File.ReadAllLines(scheduleFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                int roomId = Int32.Parse(data[0]);
                int checkupId = Int32.Parse(data[1]);
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

        public void LoadRenovations()
        {
            string[] lines = File.ReadAllLines(renovationFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                var cultureInfo = new CultureInfo("de-DE");
                string renovationElement = data[1];
                var renovationStart = DateTime.Parse(renovationElement, cultureInfo);
                renovationElement = data[2];
                var renovationEnd = DateTime.Parse(renovationElement, cultureInfo);
                if (DateTime.Today > renovationStart && DateTime.Today < renovationEnd)
                {
                    Renovation renovation = new Renovation(Int32.Parse(data[0]), renovationStart, renovationEnd);
                    currentRenovations.Add(renovation);
                }
                
            }
        }

        public void WriteToFile(string renovation)
        {
            using (StreamWriter tw = File.AppendText(renovationFileName))
            {
                tw.WriteLine(renovation);
                tw.Close();
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

        public bool isRoomRenovating(int roomId)
        {
            foreach (Renovation renovation in currentRenovations)
            {
                if (renovation.roomId == roomId)
                {
                    return true;
                }
            }
            return false; //the warehouse
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
            return FindRoom(0); //the warehouse
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

        public void AsignCheckupToRoom(Checkup checkup)
        {
            int roomId = findAvailableRoom("ExaminationRoom");



        }

        public int findAvailableRoom(string type)
        {
            foreach (Room room in rooms)
            {
                if (room.type == type)
                {
                    if (!isRoomRenovating(room.id))
                    {
                        return room.id;
                    }
                }
            }
            return -1;
        }



    }
}
