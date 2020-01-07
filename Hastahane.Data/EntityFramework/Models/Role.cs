using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
    public class Role:IEntity
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool isActive { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }

        public override string ToString()
        {
            return RoleName;
        }


    }
}
