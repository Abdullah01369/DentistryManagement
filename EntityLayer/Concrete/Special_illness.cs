using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Special_illness
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public char Level { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
