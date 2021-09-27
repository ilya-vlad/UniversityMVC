using MVC.Common;

namespace MVC.DataAccess
{
    public class GroupsRepository : Repository<Group>, IGroupsRepository
    {
        public GroupsRepository(UniversityContext context)
            : base(context)
        {
            
        }
    }
}
