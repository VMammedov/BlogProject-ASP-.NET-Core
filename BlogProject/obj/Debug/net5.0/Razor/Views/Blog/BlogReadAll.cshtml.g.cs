#pragma checksum "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c207250738dbfb72c6000a51fb189a40cc28a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
#line 1 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c207250738dbfb72c6000a51fb189a40cc28a36", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ed11178672322c160ac8464e532fc798cb594a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Comment/AddCommentPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RightSidePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogReadAll";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"mt-5\">\r\n    <!--/blog-->\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <!--left-->\r\n            <div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n");
#nullable restore
#line 14 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
                 foreach (var blog in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"blog-grid-top\">\r\n                        <div class=\"b-grid-top\">\r\n                            <div class=\"blog_info_left_grid\">\r\n                                <div>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 630, "\"", 651, 1);
#nullable restore
#line 20 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 636, blog.BlogImage, 636, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 670, "\"", 676, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 27 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
                                                                            Write(((DateTime)blog.BlogCreateDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 201 Likes
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#comments"">
                                            <i class=""far fa-comment""></i> 15 Comments
                                        </a>
                                    </li>

                                </ul>
                            </div>
                        </div>

                        <h3>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1918, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
                                  Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 49 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
                       Write(blog.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a href=\"single.html\" class=\"btn btn-primary read-m\">Read More</a>\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c207250738dbfb72c6000a51fb189a40cc28a368243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 57 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Blog\BlogReadAll.cshtml"
           Write(await Component.InvokeAsync("CommentListByBlog", new { id = ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </div>\r\n\r\n            <!--//left-->\r\n\r\n            <!--right-->\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c207250738dbfb72c6000a51fb189a40cc28a369803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <!--//right-->\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--//main-->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
