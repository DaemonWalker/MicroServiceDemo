using HIS.Constants.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.Dtos
{
    public class PatientDto
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDay { get; set; }
        public string PaientNO { get; set; }
    }
}
