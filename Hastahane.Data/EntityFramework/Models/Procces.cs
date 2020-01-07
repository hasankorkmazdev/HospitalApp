using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
   public class Procces : IEntity
    {
        public int ProccesID { get; set; }
        public string ProccesName { get; set; }
        public string ProccesDescription { get; set; }
        public bool isActive { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public override string ToString()
        {
            return ProccesName;
        }

    }
}
