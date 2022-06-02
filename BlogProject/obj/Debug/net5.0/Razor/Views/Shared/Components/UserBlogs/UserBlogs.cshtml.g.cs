#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5310f8ba820d257422bcfd75603c16032080fa7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserBlogs_UserBlogs), @"mvc.1.0.view", @"/Views/Shared/Components/UserBlogs/UserBlogs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5310f8ba820d257422bcfd75603c16032080fa7a", @"/Views/Shared/Components/UserBlogs/UserBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UserBlogs_UserBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
  
    ViewData["Title"] = "UserBlogs";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""p-3"">
    <div class=""table-bg mt-4"">
        <div class=""card-header-custom"">
            <h3>Recent Blogs</h3>
            <a href=""/Blog/BlogAdd"" class=""btn btn-primary read-m"">New Blog <span class=""fas fa-arrow-right""></span></a>
        </div>
        <div class=""card-body mt-2"">
            <div class=""table-responsive"">
                <table class=""table-custom"" style=""width: 100%;"">
                    <thead class=""thead-custom"">
                        <tr>
                            <td>Image</td>
                            <td>Title</td>
                            <td>Category</td>
                            <td>Date</td>
                            <td>Status</td>
                            <td>Operations</td>
                        </tr>
                    </thead>
                    <tbody class=""tbody-custom"">
");
#nullable restore
#line 28 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                         foreach (Blog item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img class=\"blog-small-img\"");
            BeginWriteAttribute("src", " src=\"", 1146, "\"", 1167, 1);
#nullable restore
#line 31 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
WriteAttributeValue("", 1152, item.BlogImage, 1152, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td><a href=\"#\" style=\"color: #00b868\">");
#nullable restore
#line 32 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                                                                  Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                               Write(item.BlogCreateDate.ToString("ddd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 36 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                                     if (item.BlogStatus)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status green\"></span>\r\n                                        <span>Active</span>\r\n");
#nullable restore
#line 40 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status red\"></span>\r\n                                        <span>DeActive</span>\r\n");
#nullable restore
#line 45 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td class=\"d-flex justify-content-between\">\r\n                                    <a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 2181, "\"", 2218, 2);
            WriteAttributeValue("", 2188, "/Blog/BlogReadAll/", 2188, 18, true);
#nullable restore
#line 48 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
WriteAttributeValue("", 2206, item.BlogID, 2206, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></a>\r\n                                    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 2314, "\"", 2348, 2);
            WriteAttributeValue("", 2321, "/Blog/BlogEdit/", 2321, 15, true);
#nullable restore
#line 49 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
WriteAttributeValue("", 2336, item.BlogID, 2336, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2480, 2);
            WriteAttributeValue("", 2451, "/Blog/BlogDelete/", 2451, 17, true);
#nullable restore
#line 50 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
WriteAttributeValue("", 2468, item.BlogID, 2468, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserBlogs\UserBlogs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
