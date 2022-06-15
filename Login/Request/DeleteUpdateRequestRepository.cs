using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class DeleteUpdateRequestRepository
    {
        public List<DeleteUpdateRequest> requests = new List<DeleteUpdateRequest>();
        public void LoadRequests(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                DeleteUpdateRequest request = new DeleteUpdateRequest(Int32.Parse(data[0]), data[1], int.Parse(data[2]), data[3],data[4], data[5]);
                requests.Add(request);
            }
        }

        public DeleteUpdateRequestRepository(string fileName) {
            LoadRequests(fileName);
        }

        public void AddRequestToFile(DeleteUpdateRequest request)
        {
            requests.Add(request);
            using (StreamWriter tw = File.AppendText("deleteUpdateRequests.txt"))
            {
                string line = request.id.ToString() + "|" + request.patient + "|" + request.checkup.ToString() + "|" + request.time + "|" + request.type + "|" + request.approved;
                tw.WriteLine(line);
                tw.Close();
            }
        }


        public int GetNewId()
        {
            int lastId = requests.Last().id;
            return lastId + 1;
        }

        public List<DeleteUpdateRequest> MakeCopy()
        {
            List<DeleteUpdateRequest> copy = new List<DeleteUpdateRequest>();
            foreach(DeleteUpdateRequest request in requests)
            {
                copy.Add(request);
            }
            return copy;
        }
    }
}
