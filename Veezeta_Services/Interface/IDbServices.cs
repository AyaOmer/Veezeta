using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Domain.Models;

namespace Veezeta_Services.Interface
{
   public interface IDbServices<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity); 
        void Update(T entity);
        bool Delete(int id);
        int GetCount();

    }
}
