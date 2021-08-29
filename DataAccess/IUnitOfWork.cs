using System;

namespace MVC.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();   
    }
}
