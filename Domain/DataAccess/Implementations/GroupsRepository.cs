using MVC.Common.Data;

namespace MVC.Domain.DataAccess
{
    public class GroupsRepository : Repository<Group>, IGroupsRepository
    {
        public GroupsRepository(UniversityContext context)
            : base(context)
        {

        }
    }
}
