using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Paying
    {
        public Paying()
        {
            double Price = 0;
            foreach (var item in Treatment.SpecialTreatments)
            {
                Price = Price + item.Price;
            }
            this.FinalPrice = Price;

        }
        public int Id { get; set; }

        public int TreatmentId { get; set; }
        public virtual Treatment Treatment { get; set; }

        public double FinalPrice { get; set; }

        public int SectarianId { get; set; }
        public virtual Sectarian Sectarian { get; set; }
        public bool IsPayed { get; set; }
        public bool IsActive { get; set; }
    }
}
