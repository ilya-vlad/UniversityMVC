using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Interfaces;
using MVC.Models;

namespace MVC.Implementations
{
    public class GroupsRepository : Repository<Group>, IGroupsRepository
    {
        public GroupsRepository(UniversityContext context)
            : base(context)
        {

        }
    }
}
