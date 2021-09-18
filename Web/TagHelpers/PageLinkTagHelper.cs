using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVC.Web.Models.Shared;

namespace MVC.Web.TagHelpers
{
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public IGenericPageViewModel PageModel { get; set; }
        public IGenericFilterViewModel FilterViewModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            
            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");            
            
            for(int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder currentItem = CreateTag(i, urlHelper);
                tag.InnerHtml.AppendHtml(currentItem);
            }

            output.Content.AppendHtml(tag);
        }

        TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == this.PageModel.PageNumber)
            {
                item.AddCssClass("active");                
            }
            else
            {
                link.Attributes["href"] = urlHelper.Action(PageAction, 
                    new { 
                        page = pageNumber, 
                        pageSize = PageModel.PageSize, 
                        name = FilterViewModel.SearchedName
                    });
            }
            item.AddCssClass("page-item");
            link.AddCssClass("page-link");
            link.InnerHtml.Append(pageNumber.ToString());
            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}