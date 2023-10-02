using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PayingClinic
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime FinishDate { get; set; }

        public int LevelSubscribeClinicId { get; set; }
        public virtual LevelSubscribeClinic  LevelSubscribeClinic { get; set; }

    }
}
