using HIS.Constants.Enums;
using HIS.Dtos;
using HIS.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.Repository
{
    public class DemoRepository : IPatientRepository
    {
        public PatientDto GetPatientInfoByNO(string patientNO)
        {
            return new PatientDto()
            {
                BirthDay = new DateTime(2000, 1, 1),
                Name = "张三",
                PaientNO = patientNO,
                Sex = Sex.Male,
                Tel = "4627289"
            };
        }
    }
}
