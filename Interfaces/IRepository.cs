using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Collections.Generic;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Create(T entity);
    void Update(T entity);
    void Remove(int id);   
}