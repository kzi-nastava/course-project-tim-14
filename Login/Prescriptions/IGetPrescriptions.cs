using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public interface IGetPrescriptions
    {
        List<Prescription.Prescription> GetActivePrescriptions(string patient, List<Prescription.Prescription> prescriptions);
        List<Prescription.Prescription> GetTodaysPrescriptions(string patient, List<Prescription.Prescription> prescriptions);
    }
}
