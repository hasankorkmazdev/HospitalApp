using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class ProccesDAL : ICommonDataAccesLayer<Procces>
    {
        Context.HospitalDBContext con;
        public ProccesDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(Procces entity)
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
        public int Delete(Procces entity)
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
        public int Update(Procces entity)
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
        public Procces Find(Func<Procces, bool> filter)
        {
            try
            {
                return con.Procces.Where(filter).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<Procces> FindAll(Func<Procces, bool> filter=null)
        {
            try
            {
                if (filter==null)
                {
                    return con.Procces.ToList();

                }
                return con.Procces.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
