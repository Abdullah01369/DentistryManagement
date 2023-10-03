using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class DoctorListDto:BaseDto
    {

        public  ClinicDto clinic { get; set; }
        //public int ClinicId { get; set; }
        public PeakRoom peakroom { get; set; }
        //public int PeakId { get; set; }

        //public int DegreeId { get; set; }
        public  Degree degree { get; set; }

        public DateTime InWorkDate { get; set; }
        public DateTime OutWorkDate { get; set; }
        //public string Password { get; set; }
        public bool Status { get; set; }

        //public int AddressId { get; set; }
        public  string CityName { get; set; }
    }
}
