

namespace MVC.Web.Models.Group
{
    public class GroupFilterViewModel
    {
        public string SelectedName { get; set; }

        public GroupFilterViewModel(string name)
        {
            SelectedName = name;
        }        
    }
}
