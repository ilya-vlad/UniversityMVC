using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVC.Common;

namespace Services.BreadCrumbs
{
    public interface IBreadCrumbsCreator
    {
        public void CreateNodes(ViewDataDictionary viewData);
        public void CreateNodes(ViewDataDictionary viewData, string currentName);
        public void CreateNodes(ViewDataDictionary viewData, string currentName, Course course);
        public void CreateNodes(ViewDataDictionary viewData, string currentName, Course course, Group group);
    }
}
