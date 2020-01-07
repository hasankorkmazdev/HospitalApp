using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class RoleDAL : ICommonDataAccesLayer<Role>
    {
        Context.HospitalDBContext con;
        public RoleDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(Role entity)
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
        public int Delete(Role entity)
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
        public int Update(Role entity)
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
        public Role Find(Func<Role, bool> filter)
        {
            try
            {
                return con.Role.Where(filter).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Role> FindAll(Func<Role, bool> filter=null)
        {
            try
            {
                if (filter == null)
                {
                    return con.Role.Where(x=> x.isActive==true).ToList();
                }
                return con.Role.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
