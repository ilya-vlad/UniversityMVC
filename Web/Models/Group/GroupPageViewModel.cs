using MVC.Web.Models.Shared;

namespace MVC.Web.Models.Group
{
    public class GroupPageViewModel : GenericPageViewModel<GroupPageViewModel>
    {
        public GroupPageViewModel(int count, int pageNumber, int pageSize)
             : base(count, pageNumber, pageSize)
        {

        }
    }
}