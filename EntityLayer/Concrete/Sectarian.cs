using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sectarian:BaseEntity
    {
        public DateTime InWorkDate { get; set; }
        public DateTime OutWorkDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }



        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public ICollection<Paying> Payings { get; set; }

    }
}
