#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00cfb093c38a1fd9acb0534e96d695c47f73f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00cfb093c38a1fd9acb0534e96d695c47f73f4f", @"/Areas/AdminPanel/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21bcee3e787f81b8a91016d44a0c4cffd45864c", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CategoryDashboardViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("Cards"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""pt-3"">
    <div class=""table-bg mt-4"">
        <div class=""card-header-custom"">
            <h3>Categories</h3>
            <a href=""/AdminPanel/Dashboard/ExportToExcel"" class=""btn custom-admin-button ml-auto mr-3""><i class=""fas fa-file-excel""></i> Export in Excel</a>
            <a href=""/AdminPanel/Category/AddCategory"" class=""btn custom-admin-button"">New Category <i class=""fas fa-arrow-right""></i></a>
        </div>
        <div class=""card-body mt-2"">
            <div class=""table-responsive"">
                <table class=""table-custom"" style=""width: 100%;"">
                    <thead class=""thead-custom"">
                        <tr>
                            <td>#</td>
                            <td>Category Name</td>
                            <td>Category Description</td>
                            <td>Status</td>
                            <td>Operations</td>
                        </tr>
                    </thead>
                    <tbody class=""tbody-cus");
            WriteLiteral("tom\">\r\n");
#nullable restore
#line 30 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"my-table-data\">");
#nullable restore
#line 33 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                                     Write(Model[i].CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"my-table-data\">");
#nullable restore
#line 34 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                                     Write(Model[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                 if (Model[i].CategoryDescription.Length > 30)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"my-table-data\">");
#nullable restore
#line 37 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                                         Write(Model[i].CategoryDescription.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>...</span></td>\r\n");
#nullable restore
#line 38 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"my-table-data\">");
#nullable restore
#line 41 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                                         Write(Model[i].CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("id", " id=\"", 2031, "\"", 2067, 2);
            WriteAttributeValue("", 2036, "table-data-", 2036, 11, true);
#nullable restore
#line 43 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2047, Model[i].CategoryID, 2047, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                     if (Model[i].CategoryStatus)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status green\"></span>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2295, "\"", 2338, 3);
            WriteAttributeValue("", 2305, "delCategory(", 2305, 12, true);
#nullable restore
#line 47 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2317, Model[i].CategoryID, 2317, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2337, ")", 2337, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">De Activate</a>\r\n");
#nullable restore
#line 48 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status red\"></span>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2624, "\"", 2672, 3);
            WriteAttributeValue("", 2634, "activateCategory(", 2634, 17, true);
#nullable restore
#line 52 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2651, Model[i].CategoryID, 2651, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2671, ")", 2671, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Activate</a>\r\n");
#nullable restore
#line 53 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td class=\"d-flex justify-content-between\">\r\n                                    <button class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2939, "\"", 2986, 3);
            WriteAttributeValue("", 2949, "CategoryDetails(", 2949, 16, true);
#nullable restore
#line 56 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2965, Model[i].CategoryID, 2965, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2985, ")", 2985, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                                    <a class=\"btn btn-dark\" href=\"#\"><i class=\"fas fa-edit\"></i></a>\r\n                                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3184, "\"", 3227, 3);
            WriteAttributeValue("", 3194, "delCategory(", 3194, 12, true);
#nullable restore
#line 58 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 3206, Model[i].CategoryID, 3206, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3226, ")", 3226, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">\r\n                                        <i class=\"fas fa-trash\"></i>\r\n                                    </button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 71 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\Dashboard\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", "Dashboard", new { page }), new PagedListRenderOptions
{
    PageClasses = new string[] { "page-link bg-dark text-light border-dark" },
    LiElementClasses = new string[] { "page-item" },
    DisplayLinkToLastPage = PagedListDisplayMode.Always,
    DisplayLinkToFirstPage = PagedListDisplayMode.Always,
    ContainerDivClasses = new string[] { "p-1 pt-3" },
    ActiveLiElementClass = "active-page"
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function delCategory(category_id) {
            const swalWithBootstrapButtons = Swal.mixin({
                customClass: {
                    confirmButton: 'btn btn-success',
                    cancelButton: 'btn btn-danger mr-3'
                },
                buttonsStyling: false
            })

            swalWithBootstrapButtons.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this Category!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Yes, delete it!',
                cancelButtonText: 'No, cancel!',
                reverseButtons: true
            }).then((result) => {
                if (result.isConfirmed) {
                    let timerInterval
                    Swal.fire({
                        title: 'Deleting...!',
                        html: 'I will delete in <b></b> milliseconds.',
                        timer: 1000,
 ");
                WriteLiteral(@"                       timerProgressBar: true,
                        didOpen: () => {
                            $.ajax({
                                type: 'POST',
                                url: '/AdminPanel/Category/DeleteCategory/',
                                data: { id: category_id }
                            });
                            Swal.showLoading()
                            const b = Swal.getHtmlContainer().querySelector('b')
                            timerInterval = setInterval(() => {
                                b.textContent = Swal.getTimerLeft()
                            }, 100)
                        },
                        willClose: () => {
                            clearInterval(timerInterval)
                        }
                    }).then((result) => {
                        Swal.fire({
                            icon: 'success',
                            title: 'Deleted!',
                            text: 'Your Categor");
                WriteLiteral(@"y has been deleted successfully!'
                        });
                        document.getElementById(""table-data-"" + category_id).innerHTML = `<span class=""status red""></span>
                                        <a onclick=""activateCategory(${category_id})"" class=""btn btn-outline-success"">Activate</a>`;
                    });
                } else if (
                    result.dismiss === Swal.DismissReason.cancel
                ) {
                    swalWithBootstrapButtons.fire(
                        'Cancelled',
                        'Your Category is safe :)',
                        'error'
                    )
                }
            })
        }

        function activateCategory(category_id) {
            let timerInterval
            Swal.fire({
                title: 'Activating...!',
                html: 'I will activate in <b></b> milliseconds.',
                timer: 1000,
                timerProgressBar: true,
                didOpen: () ");
                WriteLiteral(@"=> {
                    $.ajax({
                        type: 'POST',
                        url: '/AdminPanel/Category/ActivateCategory/',
                        data: { id: category_id }
                    });
                    Swal.showLoading()
                    const b = Swal.getHtmlContainer().querySelector('b')
                    timerInterval = setInterval(() => {
                        b.textContent = Swal.getTimerLeft()
                    }, 100)
                },
                willClose: () => {
                    clearInterval(timerInterval)
                }
            }).then((result) => {
                Swal.fire({
                    icon: 'success',
                    title: 'Activated!',
                    text: 'Your Category has been activated successfully!'
                });
                document.getElementById(""table-data-"" + category_id).innerHTML = `<span class=""status green""></span>
                                        <a onclick=""delC");
                WriteLiteral(@"ategory(${category_id})"" class=""btn btn-outline-danger"">De Activate</a>`;
            });
        }

        function CategoryDetails(category_id) {
            $(function () {
                $.ajax({
                    contentType: 'application/json',
                    dataType: 'json',
                    type: 'GET',
                    url: '/AdminPanel/Category/CategoryDetails/',
                    data: { id: category_id },
                    success: function (myvalue) {
                        let data = jQuery.parseJSON(myvalue);
                        Swal.fire({
                            title: `<span>Details of </span><strong class=""text-info"">${data.categoryname}</strong>`,
                            icon: 'info',
                            html:
                                `<h4><b>Category Description</b></h4>
                                <h5>${data.categorydescription}</h5>
                                <br />
                                <h4 class=""t");
                WriteLiteral(@"ext-dark""><b>The Number of Blogs : ${data.blogscount}</b></h4>`,
                            showCloseButton: true,
                            showCancelButton: true,
                            focusConfirm: false,
                            confirmButtonText:
                                '<a class=""text-white nav-link p-0"" href=""#""><i class=""fas fa-edit""></i> Edit Category</a>',
                            confirmButtonAriaLabel: 'Edit',
                            cancelButtonText:
                                '<span><i class=""fas fa-arrow-circle-left"" ></i> Cancel</span>',
                            cancelButtonAriaLabel: 'Cancel'
                        });
                    }
                })
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CategoryDashboardViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
