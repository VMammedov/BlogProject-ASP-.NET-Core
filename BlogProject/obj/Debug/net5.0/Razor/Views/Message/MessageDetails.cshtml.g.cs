#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "440cc11b9027e530fee151754f7ded0fc705a7a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440cc11b9027e530fee151754f7ded0fc705a7a5", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/_WriterPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .msg-pp-img{
        width:60px;
        height:60px;
        border-radius:50%;
    }
</style>

<div class=""p-5"">
    <div class=""bg-light p-4"" style=""border-radius:12px"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""mail-card"" style=""border-radius:12px"">
                    <div class=""card-body bg-custom text-white mailbox-widget pb-0"" style=""border-start-start-radius:12px; border-start-end-radius:12px;"">
                        <h2 class=""text-white pb-3"">Message - ");
#nullable restore
#line 22 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                         Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Details</h2>
                        <ul class=""nav nav-tabs mail-custom-tab border-bottom-0 mt-4"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button active""");
            BeginWriteAttribute("href", " href=\"", 948, "\"", 955, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""inbox-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-email""></i></span>
                                    <span class=""d-none d-md-block""> INBOX</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button""");
            BeginWriteAttribute("href", " href=\"", 1356, "\"", 1363, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""sent-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-export""></i></span>
                                    <span class=""d-none d-md-block"">SENT</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button""");
            BeginWriteAttribute("href", " href=\"", 1762, "\"", 1769, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""spam-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-panel""></i></span>
                                    <span class=""d-none d-md-block"">SPAM</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button""");
            BeginWriteAttribute("href", " href=\"", 2167, "\"", 2174, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""delete-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-trash""></i></span>
                                    <span class=""d-none d-md-block"">DELETED</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade active show"" id=""inbox"" aria-labelledby=""inbox-tab"" role=""tabpanel"">
                            <div>
                                <!-- Mail Details-->
                                <div class=""container pt-5 pb-5"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <div class=""d-flex justify-content-center align-items-center"">
                                                <img class=""msg-pp-img"" src=""https://img.search.brave.com/LzY1En6Rjk3awu");
            WriteLiteral(@"UxGSprcBH8aH3dTxbwHeE0lFwr_nI/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9hc2lh/Lm9seW1wdXMtaW1h/Z2luZy5jb20vY29u/dGVudC8wMDAwOTAw/MzMuanBn"" alt=""Profile Image"" />
                                                <div class=""ml-4"">
                                                    <h4>");
#nullable restore
#line 60 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                   Write(Model.Sender.WriterNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                    <p>");
#nullable restore
#line 61 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                  Write(Model.Sender.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-sm-8"">
                                            <div class=""d-flex justify-content-between align-items-center"">
                                                <div>
                                                    <h4 class=""font-light mb-2"" style=""font-size:1.4rem;"">Subject: ");
#nullable restore
#line 68 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                                                                              Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                    <h5 class=\"font-light\">To : ");
#nullable restore
#line 69 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                                           Write(Model.Receiver.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                </div>\r\n                                                <div>\r\n                                                    <h6><i class=\"fas fa-history\"></i> ");
#nullable restore
#line 72 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                                                                  Write(Model.MessageDate.ToString("dddd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""p-3"">
                                        <p class=""text-dark font-light"" style=""font-size:1.1rem;"">
                                            ");
#nullable restore
#line 80 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\MessageDetails.cshtml"
                                       Write(Model.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <hr />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591