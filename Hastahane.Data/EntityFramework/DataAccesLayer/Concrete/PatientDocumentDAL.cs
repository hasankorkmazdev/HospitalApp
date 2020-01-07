using Hastahane.Data.EntityFramework.DataAccesLayer.Abstract;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Concrete
{
    public class PatientDocumentDAL:ICommonDataAccesLayer<PatientDocument>
    {
        private readonly Context.HospitalDBContext con;

        public PatientDocumentDAL()
        {
            con = Context.HospitalDBContext.singleton();
        }
        public int Add(PatientDocument entity)
        {  var addedEntity = con.Entry(entity);
                addedEntity.State = System.Data.Entity.EntityState.Added;
                con.SaveChanges();
                return 1;
            
        }
        public int Delete(PatientDocument entity)
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
        public int Update(PatientDocument entity)
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
        public PatientDocument Find(Func<PatientDocument, bool> filter)
        {
            try
            {
                return con.PatientDocument.Where(filter).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<PatientDocument> FindAll(Func<PatientDocument, bool> filter)
        {
            try
            {
                return con.PatientDocument.Where(filter).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
