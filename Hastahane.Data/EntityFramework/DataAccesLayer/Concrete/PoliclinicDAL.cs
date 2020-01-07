using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class PoliclinicDAL : ICommonDataAccesLayer<Policlinic>
    {
        Context.HospitalDBContext con;
        public PoliclinicDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(Policlinic entity)
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
                return -1;
            }
        }
        public int Delete(Policlinic entity)
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
        public int Update(Policlinic entity)
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
        public Policlinic Find(Func<Policlinic, bool> filter)
        {
            try
            {
                return con.Policlinic.Where(filter).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Policlinic> FindAll(Func<Policlinic, bool> filter=null)
        {
            try
            {
                if (filter==null)
                {
                    return con.Policlinic.ToList();
                }
                return con.Policlinic.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
