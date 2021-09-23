using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVC.Web.Models.Shared;

namespace MVC.Web.TagHelpers
{
    public class PageLinkTagHelper : BaseTagHelper
    {        
        public PageLinkTagHelper(IUrlHelperFactory helperFactory) : base (helperFactory)
        {
            
        }    

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            
            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");
                        
            tag.InnerHtml.AppendHtml(CreateMoveTag("«", PageModel.PageNumber - 1, PageModel.HasPreviousPage, urlHelper));

            TagBuilder currentItem;
            foreach (var i in PageModel.GetPaginationNumbers())
            {
                currentItem = i == null ? CreateEmptyTag() : CreateTag(i.Value, urlHelper);               
                tag.InnerHtml.AppendHtml(currentItem);
            }

            tag.InnerHtml.AppendHtml(CreateMoveTag("»", PageModel.PageNumber + 1, PageModel.HasNextPage, urlHelper));
            output.Content.AppendHtml(tag);
        }

        private TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == PageModel.PageNumber)
            {
                item.AddCssClass("active");                
            }
            else
            {
                link.Attributes["href"] = urlHelper.Action(PageAction, 
                    new
                    {
                        page = pageNumber,
                        pageSize = PageModel.PageSize,
                        name = FilterViewModel.SearchedName,
                        sortOrder = SortViewModel.GetCurrent()
                    });
            }
            item.AddCssClass("page-item");
            link.AddCssClass("page-link");
            link.InnerHtml.Append(pageNumber.ToString());
            item.InnerHtml.AppendHtml(link);
            return item;
        }

        private TagBuilder CreateEmptyTag()
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");                        
            item.AddCssClass("page-item disabled");
            link.AddCssClass("page-link");
            link.InnerHtml.Append("...");
            item.InnerHtml.AppendHtml(link);
            return item;
        }   
        
        private TagBuilder CreateMoveTag(string str, int pageNumber, bool enabled, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");            
            item.AddCssClass("page-item");
            if (!enabled)
            {
                item.AddCssClass("disabled");
            }
            else
            {
                link.Attributes["href"] = urlHelper.Action(PageAction,
                    new
                    {
                        page = pageNumber,
                        pageSize = PageModel.PageSize,
                        name = FilterViewModel.SearchedName,
                        sortOrder = SortViewModel.GetCurrent()
                    });
            }            
            link.AddCssClass("page-link");
            link.InnerHtml.Append(str);
            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}