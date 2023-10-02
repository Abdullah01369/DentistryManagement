using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Boss boss { get; set; }
        public int BossId { get; set; }
        public ICollection<Doctor> doctors { get; set; }

        public int AdressClinicId { get; set; }
        public virtual AddressClinic AddressClinic { get; set; }

        public int SubscribingId { get; set; }
        public virtual Subscribing Subscribing { get; set; }

    }
}
