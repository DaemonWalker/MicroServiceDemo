using HIS.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.IRepository
{
    public interface IPatientRepository
    {
        PatientDto GetPatientInfoByNO(string patientNO);
    }
}
