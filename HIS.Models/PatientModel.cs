using HIS.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.Models
{
    public class PatientModel : HisModelBase
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string PaientNO { get; set; }
        public string BirthDay { get; set; }
    }
}
