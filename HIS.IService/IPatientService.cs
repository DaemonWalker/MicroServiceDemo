using HIS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.IService
{
    public interface IPatientService
    {
        PatientModel GetPatient(string patientNO);
    }
}
