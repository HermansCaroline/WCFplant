using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlantenServiceLibrary
{
    [DataContract]
    public class Plant
    {
        [DataMember]
        public int Nummer { get; set; }
        [DataMember]
        public string Naam { get; set; }
        [DataMember]
        public decimal Prijs { get; set; }
    }
}
