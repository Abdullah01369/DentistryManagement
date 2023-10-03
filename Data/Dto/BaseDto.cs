using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Tc { get; set; }
        public char Sex { get; set; }
        public string Mail { get; set; }
        public string Birthdate { get; set; }
    }
}
