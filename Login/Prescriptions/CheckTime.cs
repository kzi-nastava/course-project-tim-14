using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CheckTime
    {

        public bool IsTime(DateTime prescriptionTime,int hours)
        {
            return prescriptionTime.AddHours(hours).TimeOfDay < DateTime.Now.TimeOfDay;
        }
    }
}
