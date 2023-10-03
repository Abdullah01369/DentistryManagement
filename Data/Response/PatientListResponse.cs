using Data.Attribute;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Response
{
    public class PatientListResponse
    {
        public Status Statu { get; set; }
        public List<Patient> Patient { get; set; }
    }
}
