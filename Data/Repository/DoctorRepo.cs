using Data.ConnectionDb;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class DoctorRepo
    {
        Context context = new Context();

        public Doctor Getir(int id)
        {
            return context.Doctors.FirstOrDefault(x => x.Id == id);
        }

        /*
        public int Update(Doctor entity)
        {

        }
        */


        public List<Doctor> DoctorList()
        {
            return context.Doctors.ToList();
        }



        
    }
}
