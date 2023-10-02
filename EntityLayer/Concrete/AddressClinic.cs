using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AddressClinic
    {
        public int Id { get; set; }

        public int CityId { get; set; }
        public City city { get; set; }
        public string Declaration { get; set; }
        public ICollection<Clinic> Clinics { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
