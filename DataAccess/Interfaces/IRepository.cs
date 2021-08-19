using System.Collections.Generic;
using System.Linq;

namespace MVC.DataAccess
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Remove(int id);
    }
}