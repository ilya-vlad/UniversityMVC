using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Localization;
using MVC.Common;
using SmartBreadcrumbs.Nodes;
using System.Collections.Generic;

namespace Services.BreadCrumbs
{
    public class BreadCrumbsCreator : IBreadCrumbsCreator
    {
        public readonly IStringLocalizer<BreadCrumbsCreator> _localizer;
        public BreadCrumbsCreator(IStringLocalizer<BreadCrumbsCreator> localizer)
        {
            _localizer = localizer;
        }
        
        public void CreateNodes(ViewDataDictionary viewData)
        {
            Process(viewData, null, null, null);
        }

        public void CreateNodes(ViewDataDictionary viewData, string currentName)
        {
            Process(viewData, currentName, null, null);
        }

        public void CreateNodes(ViewDataDictionary viewData, string currentName, Course course)
        {
            Process(viewData, currentName, course, null);
        }

        public void CreateNodes(ViewDataDictionary viewData, string currentName, Course course, Group group)
        {
            Process(viewData, currentName, course, group);            
        }

        private void Process(ViewDataDictionary viewData, string currentName, Course course, Group group)
        {
            var stackNodes = new LinkedList<MvcBreadcrumbNode>();
            if (group != null)
            {
                if (currentName != null)
                {
                    stackNodes.AddLast(new MvcBreadcrumbNode("", "", currentName));
                    currentName = null;
                }
                stackNodes.AddLast(new MvcBreadcrumbNode("Index", "Students", $"{_localizer["Students"]} ({group.Name})")
                {
                    RouteValues = new { idCourse = course.Id, idGroup = group.Id }
                });
            }

            if(course != null)
            {
                if (currentName != null)
                {
                    stackNodes.AddLast(new MvcBreadcrumbNode("", "", currentName));
                    currentName = null;
                }
                stackNodes.AddLast(new MvcBreadcrumbNode("Index", "Groups", $"{_localizer["Groups"]} ({course.Name})")
                {
                    RouteValues = new { idCourse = course.Id }
                });
            }

            if(currentName != null)
            {
                stackNodes.AddLast(new MvcBreadcrumbNode("", "", currentName));
            }

            var result = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            MvcBreadcrumbNode temp = null;
            while(stackNodes.Count > 0)
            {
                stackNodes.Last.Value.Parent = temp == null ? result : temp;
                temp = stackNodes.Last.Value;
                stackNodes.RemoveLast();
            }
            viewData["BreadcrumbNode"] = temp == null ? result : temp;
        }
    }
}