using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class PatientDAL : ICommonDataAccesLayer<Patient>, IPatientDAL<Patient>
    {
        readonly Context.HospitalDBContext con;
        public PatientDAL()
        {
            con =  Context.HospitalDBContext.singleton();
        }
        public int Add(Patient entity)
        {
            
                var addedEntity = con.Entry(entity);
                addedEntity.State = System.Data.Entity.EntityState.Added;
                con.SaveChanges();
                return 1;
            
            
                return 0;
            
        }
        public int Delete(Patient entity)
        {
            try
            {
                var deleteEntity = con.Entry(entity);
                deleteEntity.State = System.Data.Entity.EntityState.Deleted;
                con.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
                
            }
        }
        public int Update(Patient entity)
        {
            try
            {
                var modifiedEntity = con.Entry(entity);
                modifiedEntity.State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Patient Find(Func<Patient, bool> filter)
        {
            try
            {
                return con.Patients.Where(filter).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Patient> FindAll(Func<Patient, bool> filter=null )
        {
            try
            {
                if (filter==null)
                {
                    return con.Patients.ToList();

                }
                return con.Patients.Where(filter).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
