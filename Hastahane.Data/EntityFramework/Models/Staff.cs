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
    public enum BloodTypes : byte
    {
        APozitif = 0, 
        ANegatif, 
        BPozitif, 
        BNegatif,
        ABPozitif,
        ABNegatif,
        SıfırPozitif,
        SıfırNegatif
    }
    public enum CivilStatus : byte
    {
        Bekar = 0,
        Evli
    }
    public enum Gender:byte
    {
        Erkek=0,
        Kadın
    }
    public class Staff : IEntity
    {


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StaffCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(14)]
        public string Tel1 { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(14)]
        public string Tel2 { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string Adress { get; set; }
        public bool isActive { get; set; }
        public decimal Salary { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime EntryDate { get; set; }
        public BloodTypes BloodType { get; set; }
        public Gender Gender { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public virtual Role Role { get; set; }
        public int RoleID { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public virtual Policlinic Policlinic { get; set; }
        public int PoliclinicID { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }

        public override string ToString()
        {
            return Name+" "+Surname;
        }



    }
}
