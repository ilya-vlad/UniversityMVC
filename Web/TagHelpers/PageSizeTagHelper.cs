using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVC.Web.Models.Shared;
using System.Collections.Generic;

namespace MVC.Web.TagHelpers
{
    public class PageSizeTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageSizeTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public IGenericPageViewModel PageModel { get; set; }
        public IGenericFilterViewModel FilterViewModel { get; set; }
        public IGenericSortViewModel SortViewModel { get; set; }
        public List<int> ListPageSizes { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder select = new TagBuilder("select");
            select.AddCssClass("custom-select");
            select.Attributes["onchange"] = "document.location.href = '" + urlHelper.Action(PageAction) 
                + $"?pagesize=' + this.options[this.selectedIndex].value + '&name={FilterViewModel.SearchedName}&sortOrder={SortViewModel.GetCurrent()}'";                  

            foreach (int size in ListPageSizes)
            {
                TagBuilder option = new TagBuilder("option");
                option.InnerHtml.Append(size.ToString());
               
                if(size == PageModel.PageSize)
                {
                    option.Attributes["selected"] = "selected";
                }
                select.InnerHtml.AppendHtml(option);
            }
            output.Content.AppendHtml(select);
        }
    }
}