using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVC.Web.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Web.TagHelpers
{
    public class BaseTagHelper : TagHelper
    {
        public IUrlHelperFactory _urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public IGenericPageViewModel PageModel { get; set; }
        public IGenericFilterViewModel FilterViewModel { get; set; }
        public IGenericSortViewModel SortViewModel { get; set; }        
        public string PageAction { get; set; }
        public BaseTagHelper(IUrlHelperFactory helperFactory)
        {
            _urlHelperFactory = helperFactory;
        }
    }
}
