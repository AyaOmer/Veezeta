using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta_Infrastrucure.DBContext;
using Veezeta_Services.Interface;

namespace Veezeta_Services.Services
{
    public class DbServices<T> : IDbServices<T> where T : class
    {
        private readonly AppDBContext context;
        private readonly DbSet<T> _entities;

        public DbServices(AppDBContext _context)
        {
            context = _context;
            _entities = context.Set<T>();
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public bool Delete(int id)
        {
            var result = _entities.Find(id);
            if (result == null)
                return false;

            _entities.Remove(result);
            return true;

        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);

        }

        public void Update(T entity)
        {
            _entities.Update(entity);

        }
        public int GetCount()
        {
            return _entities.ToList().Count;
        }
    }
}
