﻿using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor:BaseEntity
    {
        public virtual Clinic clinic { get; set; }
        public int ClinicId { get; set; }
        public PeakRoom peakroom { get; set; }
        public int PeakId { get; set; }

        public int DegreeId { get; set; }
        public virtual Degree degree { get; set; }

        public DateTime InWorkDate { get; set; }
        public DateTime OutWorkDate { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Sectarian> Sectarians { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }

    }
}
