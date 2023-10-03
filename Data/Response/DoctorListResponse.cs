using Data.Attribute;
using Data.Dto;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Response
{
    public class DoctorListResponse
    {
        public Status statu { get; set; }
        public List<DoctorListDto> Doktorlist { get; set; }
    }
}
