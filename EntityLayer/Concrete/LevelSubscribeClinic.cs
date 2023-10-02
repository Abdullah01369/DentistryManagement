using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LevelSubscribeClinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Month { get; set; }
        public ICollection<PayingClinic> payingClinics { get; set; }
    }
}
