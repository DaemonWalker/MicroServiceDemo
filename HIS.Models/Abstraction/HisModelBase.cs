using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HIS.Models.Abstraction
{
    [DataContract]
    public abstract class HisModelBase
    {
        [DataMember]
        public string JToken { get; set; }
        [DataMember]
        public string Token { get; set; }
    }
}
