﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/Changes.cshtml")]
    public partial class Changes : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.ChangesViewModel>
    {
        public Changes()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\Changes.cshtml"
  
    Layout = "~/Views/IlaroAdmin/_Layout.cshtml";
    ViewBag.Title = Resources.IlaroAdminResources.Changes + " " + Model.EntityChangesFor.Plural;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 11 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.ActionLink(Resources.IlaroAdminResources.Index_Title, "Index"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.ActionLink(Model.EntityChangesFor.GroupName, "Group", new { groupName = Model.Entity.GroupName }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 13 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.ActionLink(Model.EntityChangesFor.Plural, "Details", new { entityName = Model.EntityChangesFor.Name }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\IlaroAdmin\Changes.cshtml"
                      Write(Resources.IlaroAdminResources.Changes);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\IlaroAdmin\Changes.cshtml"
                     Write(Model.Entity.Plural);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 20 "..\..\Views\IlaroAdmin\Changes.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\IlaroAdmin\Changes.cshtml"
     if (Model.IsSearchActive)
    {
        using (Html.BeginForm("Details", "IlaroAdmin", new { page = Model.PagerInfo.Current }, FormMethod.Get, new { @class = "pull-left col-md-3" }))
        {
            foreach (var filter in Model.ActiveFilters)
            {
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\IlaroAdmin\Changes.cshtml"
           Write(Html.Hidden(filter.Property.Name, filter.Value));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                                
            }
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("entityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                         
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("pp", Model.PerPage));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                             
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("o", Model.Order));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                          
            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("od", Model.OrderDirection));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Views\IlaroAdmin\Changes.cshtml"
           Write(Html.TextBox("sq", Model.SearchQuery, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                             Write(Resources.IlaroAdminResources.Search);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                </span>\r\n            </div>\r\n");

            
            #line 38 "..\..\Views\IlaroAdmin\Changes.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(" style=\"margin-bottom:10px\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"btn-group btn-group-sm pull-right\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"btn btn-default active\"");

WriteLiteral(" id=\"make-table-large\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-th-large\"");

WriteLiteral("></span></button>\r\n        <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" id=\"make-table-condensed\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-th\"");

WriteLiteral("></span></button>\r\n    </div>\r\n</div>\r\n\r\n<table");

WriteLiteral(" id=\"table-entity\"");

WriteLiteral(" class=\"table table-striped table-bordered table-hover\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 52 "..\..\Views\IlaroAdmin\Changes.cshtml"
            
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\IlaroAdmin\Changes.cshtml"
             foreach (var column in Model.Columns)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th>\r\n                    <span ");

            
            #line 55 "..\..\Views\IlaroAdmin\Changes.cshtml"
                     Write(Html.Condition(!string.IsNullOrEmpty(column.Description), () => "title=\"" + column.Description + "\""));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 56 "..\..\Views\IlaroAdmin\Changes.cshtml"
                   Write(Html.SortColumnLink(Model.Entity, column, Model.Filters, Model.SearchQuery, Model.PerPage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2535), Tuple.Create("\"", 2592)
, Tuple.Create(Tuple.Create("", 2543), Tuple.Create("glyphicon", 2543), true)
, Tuple.Create(Tuple.Create(" ", 2552), Tuple.Create("glyphicon-chevron-", 2553), true)
            
            #line 57 "..\..\Views\IlaroAdmin\Changes.cshtml"
, Tuple.Create(Tuple.Create("", 2571), Tuple.Create<System.Object, System.Int32>(column.SortDirection
            
            #line default
            #line hidden
, 2571), false)
);

WriteLiteral("></i>\r\n                    </span>\r\n                </th>\r\n");

            
            #line 60 "..\..\Views\IlaroAdmin\Changes.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 64 "..\..\Views\IlaroAdmin\Changes.cshtml"
        
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\IlaroAdmin\Changes.cshtml"
         foreach (var row in Model.Data)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 67 "..\..\Views\IlaroAdmin\Changes.cshtml"
                
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\IlaroAdmin\Changes.cshtml"
                 foreach (var item in row.Values)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 69 "..\..\Views\IlaroAdmin\Changes.cshtml"
                   Write(Html.DisplayFor(m => item, item.Property.DisplayTemplateName));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 70 "..\..\Views\IlaroAdmin\Changes.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 72 "..\..\Views\IlaroAdmin\Changes.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"margin-right:10px\"");

WriteLiteral(">\r\n");

            
            #line 78 "..\..\Views\IlaroAdmin\Changes.cshtml"
        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\IlaroAdmin\Changes.cshtml"
         using (Html.BeginForm("Details", "IlaroAdmin", new { page = Model.PagerInfo.Current }, FormMethod.Get, new { @class = "form-inline" }))
        {
            foreach (var filter in Model.ActiveFilters)
            {
                
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\IlaroAdmin\Changes.cshtml"
           Write(Html.Hidden(filter.Property.Name, filter.Value));

            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                                
            }
            
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("entityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                         
            
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("sq", Model.SearchQuery));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                 
            
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("o", Model.Order));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                          
            
            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Html.Hidden("od", Model.OrderDirection));

            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"pp\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                 Write(Resources.IlaroAdminResources.OnPage);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

WriteLiteral("                ");

            
            #line 90 "..\..\Views\IlaroAdmin\Changes.cshtml"
           Write(Html.DropDownList("pp",
                 new SelectList(new Dictionary<int, int> { { 5, 5 }, { 10, 10 }, { 15, 15 }, { 20, 20 }, { 25, 25 }, { 50, 50 }, { 100, 100 } }, "Key", "Value", 10),
                 new Dictionary<string, object> { { "class", "autoPostBack form-control" }, { "id", "per-page-entity" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 94 "..\..\Views\IlaroAdmin\Changes.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"margin-right:10px\"");

WriteLiteral(">\r\n");

            
            #line 98 "..\..\Views\IlaroAdmin\Changes.cshtml"
        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\IlaroAdmin\Changes.cshtml"
          Html.RenderPartial("_Paging", Model.PagerInfo);
            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"line-height:29px\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                               Write(Resources.IlaroAdminResources.Founded);

            
            #line default
            #line hidden
WriteLiteral(" <strong>");

            
            #line 101 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                                                              Write(Model.PagerInfo.TotalItems);

            
            #line default
            #line hidden
WriteLiteral("</strong></div>\r\n</div>\r\n\r\n");

DefineSection("Sidebar", () => {

WriteLiteral("\r\n");

            
            #line 106 "..\..\Views\IlaroAdmin\Changes.cshtml"
    
            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\IlaroAdmin\Changes.cshtml"
     if (Model.Filters.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h2>");

            
            #line 108 "..\..\Views\IlaroAdmin\Changes.cshtml"
       Write(Resources.IlaroAdminResources.Filters);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 4587), Tuple.Create("\"", 4688)
            
            #line 110 "..\..\Views\IlaroAdmin\Changes.cshtml"
, Tuple.Create(Tuple.Create("", 4594), Tuple.Create<System.Object, System.Int32>(Url.Action("Details", new { entityName = Model.Entity.Name, page = Model.PagerInfo.Current })
            
            #line default
            #line hidden
, 4594), false)
);

WriteLiteral(">");

            
            #line 110 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                                                                                    Write(Resources.IlaroAdminResources.RemoveFilters);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 111 "..\..\Views\IlaroAdmin\Changes.cshtml"
            
            
            #line default
            #line hidden
            
            #line 111 "..\..\Views\IlaroAdmin\Changes.cshtml"
             foreach (var filter in Model.Filters)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"nav-header\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 115 "..\..\Views\IlaroAdmin\Changes.cshtml"
               Write(filter.Property.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n");

            
            #line 117 "..\..\Views\IlaroAdmin\Changes.cshtml"
                foreach (var option in filter.Options)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li ");

            
            #line 119 "..\..\Views\IlaroAdmin\Changes.cshtml"
                   Write(Html.Condition(option.Selected, () => "class=\"active\""));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 119 "..\..\Views\IlaroAdmin\Changes.cshtml"
                                                                              Write(Html.FilterOptionLink(Model.Entity, filter, option, Model.Filters, Model.SearchQuery, Model.Order, Model.OrderDirection, Model.PerPage));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 120 "..\..\Views\IlaroAdmin\Changes.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 123 "..\..\Views\IlaroAdmin\Changes.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $().ready(function () {
            $('#make-table-large').click(function () {
                var $this = $(this).addClass('active').siblings().removeClass('active');
                $('#table-entity').removeClass('table-condensed');
                $('#pagination-entity').removeClass('pagination-sm');
                $('#per-page-entity').removeClass('select-sm');
            });
            $('#make-table-condensed').click(function () {
                var $this = $(this).addClass('active').siblings().removeClass('active');
                $('#table-entity').addClass('table-condensed');
                $('#pagination-entity').addClass('pagination-sm');
                $('#per-page-entity').addClass('select-sm');
            });
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591
