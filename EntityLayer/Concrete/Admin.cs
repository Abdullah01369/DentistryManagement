using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin:BaseEntity
    {
        public char Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
