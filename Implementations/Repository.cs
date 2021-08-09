using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MVC.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly UniversityContext Context;


        public Repository(UniversityContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            Context.Set<T>().Add(entity);            
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);

        }

        public void Remove(int id)
        {
            var type = Context.Set<T>().Find(id);
            Context.Remove(type);
        }        

        public void Update(T entity)
        {            
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}