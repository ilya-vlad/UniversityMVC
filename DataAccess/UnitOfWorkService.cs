using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DataAccess
{
    public class UnitOfWorkService
    {
        protected internal IUnitOfWork UnitOfWork { get; }
        public UnitOfWorkService(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }
    }
}
