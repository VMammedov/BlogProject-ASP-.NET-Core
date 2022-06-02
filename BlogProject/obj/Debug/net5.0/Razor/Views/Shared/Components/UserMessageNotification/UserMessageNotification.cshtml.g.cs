#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f187a86d90275e9eb21b825b91a23767235d69b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserMessageNotification_UserMessageNotification), @"mvc.1.0.view", @"/Views/Shared/Components/UserMessageNotification/UserMessageNotification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f187a86d90275e9eb21b825b91a23767235d69b", @"/Views/Shared/Components/UserMessageNotification/UserMessageNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UserMessageNotification_UserMessageNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserMessagesPopUpViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
  
    DateTime current = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<button class=""nav-link nav-button"" data-toggle=""modal"" data-target=""#MessageModal"">
    <i class=""fas fa-envelope""></i> Messages
</button>

<!-- Modal -->
<div class=""modal fade"" id=""MessageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""MessageModalTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header d-flex align-items-center"">
                <h5 class=""modal-title"" id=""MessageModalTitle""><i class=""fas fa-envelope""></i> Messages</h5>
                <a class=""custom-button ml-3"" style=""border-radius:6px;"" href=""/Message/Inbox"">See All</a>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-left p-4"">
");
#nullable restore
#line 23 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                 foreach (UserMessagesPopUpViewModel item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center mb-3\">\r\n                        <div class=\"card-header card-notification\">\r\n                            <div>\r\n                                ");
#nullable restore
#line 28 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                           Write(item.Sender.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text-center\">\r\n                                <p class=\"text-light\" style=\"font-size:.8rem\">");
#nullable restore
#line 31 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                                                                         Write(item.Sender.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-body\" style=\"color: #01cd74;\">\r\n                            <h5 class=\"card-title p-2 m-0\">");
#nullable restore
#line 35 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                                                      Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 36 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                                            Write(Html.Raw(@item.MessageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer text-light card-notification-date \">\r\n");
#nullable restore
#line 39 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                              
                                string msgdate = (int)current.Subtract(item.MessageDate).TotalDays != 0 ?
                                ((int)current.Subtract(item.MessageDate).TotalDays + " day " + ((int)current.Subtract(item.MessageDate).TotalHours % 24) + " hours ago...").ToString() :
                                ((int)current.Subtract(item.MessageDate).TotalHours % 24) != 0 ? (((int)current.Subtract(item.MessageDate).TotalHours % 24) + " hours ago...").ToString() :
                                (((int)current.Subtract(item.MessageDate).Minutes) + " minutes ago...").ToString();
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 45 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                       Write(msgdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 49 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\UserMessageNotification\UserMessageNotification.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""modal-footer"">
                <a href=""/Message/Inbox"" class=""btn nav-link"">See All</a>
                <button type=""button"" class=""btn nav-link"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserMessagesPopUpViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
