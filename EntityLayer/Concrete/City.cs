using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<District> districts { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AddressClinic> AddressClinics { get; set; }

    }
}
