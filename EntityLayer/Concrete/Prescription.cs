using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Prescription
    {
        public int Id { get; set; }
        public string MedicineDeclareation { get; set; }
        public DateTime GivingDate { get; set; }
        public DateTime DeadDate { get; set; }

      
        public virtual Treatment Treatment { get; set; }

    }
}
