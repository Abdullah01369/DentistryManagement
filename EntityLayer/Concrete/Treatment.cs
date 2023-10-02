using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Treatment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }


        public int PrescriptionId { get; set; }
        public virtual Prescription  Prescription { get; set; }

        public virtual ICollection<SpecialTreatments> SpecialTreatments { get; set; }

        public DateTime Date { get; set; }
        public string Declareation { get; set; }

    }
}
