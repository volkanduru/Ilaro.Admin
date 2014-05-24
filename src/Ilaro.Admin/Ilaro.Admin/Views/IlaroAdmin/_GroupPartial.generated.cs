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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/_GroupPartial.cshtml")]
    public partial class GroupPartial : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.EntityGroupViewModel>
    {
        public GroupPartial()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
 if (!Model.Name.IsNullOrEmpty())
{

            
            #line default
            #line hidden
WriteLiteral("    <h3>");

            
            #line 5 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
   Write(Html.ActionLink(Model.Name, "Group", new { groupName = Model.Name }));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 6 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<table");

WriteLiteral(" class=\"table table-striped table-bordered table-hover\"");

WriteLiteral(">\r\n    <tbody>\r\n");

            
            #line 9 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
         foreach (var entity in Model.Entities)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"max-width\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
                                 Write(Html.ActionLink(entity.Plural, "List", new { entityName = entity.Name }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n");

            
            #line 14 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
                     if (entity.CanAdd)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 564), Tuple.Create("\"", 626)
            
            #line 16 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
, Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", new { entityName = entity.Name })
            
            #line default
            #line hidden
, 571), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphglyphicon glyphicon-plus\"");

WriteLiteral("></span> ");

            
            #line 16 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
                                                                                                                                                                               Write(Resources.IlaroAdminResources.Add);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 17 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 20 "..\..\Views\IlaroAdmin\_GroupPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
