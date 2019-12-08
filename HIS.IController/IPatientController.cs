using HIS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.IController
{
    public interface IPatientController
    {
        PatientModel GetPatient(PatientModel patient);
    }
}
