using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Models
{
   public class Transaction : IEntity
    {
        [Key]
        public int TransactionID { get; set; }
        public decimal Price { get; set; }
        public int Piece { get; set; }
        public int QueueNumber { get; set; }
        public DateTime ProccesDate { get; set; }
        public int ProccesID { get; set; }
        public string PatientDocumentID { get; set; }
        public string StaffCode { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Procces Procces { get; set; }
        public virtual PatientDocument PatientDocument { get; set; }
    }
}
