using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HIS.Service.Abstraction
{
    [DataContract]
    public abstract class HisModelBase
    {
        [DataMember]
        public string JTken { get; set; }
    }
}
