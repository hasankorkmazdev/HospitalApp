using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Context
{
    internal class HospitalDBContext : DbContext
    {
        private static HospitalDBContext context;

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Procces> Procces { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<PatientDocument> PatientDocument { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Policlinic> Policlinic { get; set; }

        private HospitalDBContext() : base(Hastahane.Data.Properties.Settings.Default.ConString)
        {
            Database.SetInitializer(new HospitalDBInitilazier());
        }
        public static HospitalDBContext singleton()
        {
            if (context==null)
            {
                context = new HospitalDBContext();
            }
            return context;
        }



    }


}
