using Hastahane.Data.EntityFramework.Models;
using Hastahane.Data.EntityFramework.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.DataAccesLayer.Abstract
{
    interface ICommonDataAccesLayer<T> where T:IEntity,new()
    {
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
        T Find(Func<T, bool> filter);
        List<T> FindAll(Func<T, bool> filter);
    }
}
