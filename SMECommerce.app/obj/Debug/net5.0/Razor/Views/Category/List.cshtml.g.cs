#pragma checksum "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f330e509e0f76a9a8bb39fa9db5c10dc8c39e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_List), @"mvc.1.0.view", @"/Views/Category/List.cshtml")]
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
#line 1 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app.Models.Auth;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f330e509e0f76a9a8bb39fa9db5c10dc8c39e1b", @"/Views/Category/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11fcc35fed188ae2b50e22ad0b21e139ce1cc8f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMECommerce.app.Models.CategoryModels.CategoryListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge bg-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge bg-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
   
    //List<Category> categoryList = ViewBag.CategoryList;
    int serialNo = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">Category List</h3>\r\n        <div class=\"card-tools\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f330e509e0f76a9a8bb39fa9db5c10dc8c39e1b7141", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th style=""width: 10px"">#</th>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Code</th>
                    <th style=""width: 40px"">Edit</th>
                    <th style=""width: 40px"">Delete</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 43 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                 foreach (var category in Model.CategoryList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                        Write(++serialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                       Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                       Write(category.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f330e509e0f76a9a8bb39fa9db5c10dc8c39e1b10871", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                                                                          WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f330e509e0f76a9a8bb39fa9db5c10dc8c39e1b13332", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                                                                           WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Rashed\Desktop\Professional\ASP.NET_Core_MVC_with_ Angular_and _EF_Core\TrainnigWorkspace\ASP.NET_Core_MVC\Practice\SMECommerce\SMECommerce.app\Views\Category\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </tbody>
        </table>
    </div>
    <!-- /.card-body -->
    <div class=""card-footer clearfix"">
        <ul class=""pagination pagination-sm m-0 float-right"">
            <li class=""page-item""><a class=""page-link"" href=""#"">&laquo;</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">&raquo;</a></li>
        </ul>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMECommerce.app.Models.CategoryModels.CategoryListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
