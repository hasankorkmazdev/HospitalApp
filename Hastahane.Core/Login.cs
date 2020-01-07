using Hastahane.Data.EntityFramework.DataAccesLayer.Concrete;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Core
{
   public class Login
    {
       readonly StaffDAL staffDAL = new StaffDAL();
        public bool LoginValidation(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password) || password.Length < 8)
            {
                //Giriş değerlerinin doğrulanması
                return false;
            }
            return true;
        }
        public bool LoginControl(string userName, string password)
        {
            Staff loginUser;
            loginUser = staffDAL.Find(q => q.Username == userName.ToUpper());
            if (loginUser!=null && loginUser.Username == userName.ToUpper() && loginUser.Password == password)
            {
                return true;
            }
            return false;
        }
        public Staff LoginCompleted(string userName)
        {
           return (Hastahane.Data.EntityFramework.Models.Staff)staffDAL.Find(q=> q.Username==userName);
        }
    }
}
