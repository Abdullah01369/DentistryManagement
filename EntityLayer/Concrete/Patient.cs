using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Patient:BaseEntity
    {
        public ICollection<Special_illness> Special_illnesses { get; set; }
        public int AddressPatientId { get; set; }
        public virtual AddressPatient AddressPatient { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }


    }
}
