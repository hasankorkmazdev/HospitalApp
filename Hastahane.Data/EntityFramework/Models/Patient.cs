using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
    public class Patient : IEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TCNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Adress { get; set; }
        public DateTime BornDate { get; set; }
        public Models.BloodTypes BloodType { get; set; }
        public Models.Gender Gender { get; set; }
        public Models.CivilStatus CivilStatus { get; set; }
        [NotMapped]
        public int Age
        {
            get 
            {
                if (BornDate!= DateTime.Parse("01-01-0001"))
                {
                    TimeSpan ts = DateTime.Now - BornDate;
                   return (int)Math.Floor((double)ts.Days / 365);
                }
                else
                {
                  
                }
                return 0;

            }
        }

        public virtual ICollection<PatientDocument> PatientDocument { get; set; }





    }
}
