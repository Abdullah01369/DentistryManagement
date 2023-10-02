using Data.ConnectionDb;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class PatientRepo
    {
        Context context=new Context();

        public Patient Getir(int id)
        {
            return context.Patients.AsNoTracking().Where(x =>x.Id==id).SingleOrDefault();
        }

        public int Guncelle(Patient entity)
        {
            
            return context.SaveChanges();
        } //

        public Patient Kaydet(Patient entity)
        {
            context.Patients.Add(entity);
            context.SaveChanges();
            return entity;
        }
       

        public List<Patient> Listele()
        {
            return context.Patients.AsNoTracking().ToList();
        }

        public List<Patient> Listele(Expression<Func<Patient, bool>> predicate)
        {
            return context.Patients.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
           
            var Patient = Getir(id);
            return Sil(Patient);
        }


        public bool Sil(Patient entity)
        {
            context.Patients.Remove(entity);
            return context.SaveChanges() > 0;
        }
    }
}
