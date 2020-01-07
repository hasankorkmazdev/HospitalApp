using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
    public class Policlinic:IEntity
    {
        [Key]
        public int PoliclinicID { get; set; }
        public string PoliclinicName { get; set; }
        public string PoliclinicDetails { get; set; }
        public bool isActive { get; set; }

        public override string ToString()
        {
            return PoliclinicName;
        }
    }
}
