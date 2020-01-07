using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class StaffDAL : IStaffDAL<Staff>, ICommonDataAccesLayer<Staff>
    {
        readonly Context.HospitalDBContext con;
        public StaffDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(Staff entity)
        {
            try
            {
                var addedEntity = con.Entry(entity);
                addedEntity.State = System.Data.Entity.EntityState.Added;
                con.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int Delete(Staff entity)
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
        public int Update(Staff entity)
        {
            
                var modifiedEntity = con.Entry(entity);
                modifiedEntity.State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
                return 1;
            
            
        }
        public Staff Find(Func<Staff, bool> filter)
        {
          
                return con.Staff.Where(filter).FirstOrDefault();

        }
        public List<Staff> FindAll(Func<Staff, bool> filter=null)
        {
            try
            {
                if (filter==null)
                {
                    return con.Staff.ToList();

                }

                return con.Staff.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
