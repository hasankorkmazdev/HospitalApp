using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class TransactionDAL : ICommonDataAccesLayer<Transaction>
    {
        Context.HospitalDBContext con;
        public TransactionDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(Transaction entity)
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
        public int Delete(Transaction entity)
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
        public int Update(Transaction entity)
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
        public Transaction Find(Func<Transaction, bool> filter)
        {
            try
            {
                return con.Transaction.Where(filter).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<Transaction> FindAll(Func<Transaction, bool> filter)
        {
            try
            {
                return con.Transaction.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
