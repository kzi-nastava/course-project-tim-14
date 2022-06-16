using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Survey:IConverter
    {
        public int id;
        public int patientId;
        public int quality;
        public int hygiene;
        public int rating;
        public int recommend;
        public string comment;
        public string type;

        public Survey(int id, int patientId, int quality, int hygiene, int rating, int recommend, string comment,string type) {
            this.id = id;
            this.patientId = patientId;
            this.quality = quality;
            this.hygiene = hygiene;
            this.rating = rating;
            this.recommend = recommend;
            this.comment = comment;
            this.type = type;
        }
        public void AddComment() {
            if (this.comment.Equals(""))
                this.comment = "n/a";
        }

        public bool IsValid()
        {
            return quality != -1 && rating != -1 && recommend != -1;
              
        }

        public string FormatToString() {
            return  id + "|" + patientId + "|" + quality + "|" + hygiene + "|" + rating + "|" + recommend + "|" + comment + "|" + type;

        }
    }
}
