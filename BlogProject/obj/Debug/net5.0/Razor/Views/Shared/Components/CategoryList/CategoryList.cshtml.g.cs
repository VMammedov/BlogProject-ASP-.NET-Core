#pragma checksum "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Shared\Components\CategoryList\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee1216e680b3b76e6826b6780429df565a22bb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_CategoryList), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee1216e680b3b76e6826b6780429df565a22bb0", @"/Views/Shared/Components/CategoryList/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ed11178672322c160ac8464e532fc798cb594a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Categories</h4>\r\n    <ul class=\"list-group single\">\r\n");
#nullable restore
#line 6 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Shared\Components\CategoryList\CategoryList.cshtml"
         foreach (Category category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                ");
#nullable restore
#line 9 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Shared\Components\CategoryList\CategoryList.cshtml"
           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"badge badge-primary badge-pill\">25</span>\r\n            </li>\r\n");
#nullable restore
#line 12 "C:\Users\Vusal Mammadli\source\repos\BlogProject\BlogProject\Views\Shared\Components\CategoryList\CategoryList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591