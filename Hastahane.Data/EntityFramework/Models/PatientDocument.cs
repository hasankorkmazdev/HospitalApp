using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
   public class PatientDocument : IEntity
    {
        [Key]
        public string PatientDocumentID { get; set; }
        public DateTime CreateDocumentDate { get; set; }
        public DateTime? CloseDocumentDate { get; set; }
        public string TCNumber { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
