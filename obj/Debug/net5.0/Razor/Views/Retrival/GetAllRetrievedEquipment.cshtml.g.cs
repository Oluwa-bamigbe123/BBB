#pragma checksum "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56c01b71d257ca4b3c46867ebb7710ef8535e5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Retrival_GetAllRetrievedEquipment), @"mvc.1.0.view", @"/Views/Retrival/GetAllRetrievedEquipment.cshtml")]
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
#line 1 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\_ViewImports.cshtml"
using LocalBetBiga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\_ViewImports.cshtml"
using LocalBetBiga.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56c01b71d257ca4b3c46867ebb7710ef8535e5f", @"/Views/Retrival/GetAllRetrievedEquipment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec3c06dc0a026f3bdfa2c90e178675b07e27e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Retrival_GetAllRetrievedEquipment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocalBetBiga.Models.Entities.Retrival>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/FileSaver.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
   Layout = "_ManagerDashboardLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a56c01b71d257ca4b3c46867ebb7710ef8535e5f5099", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - InventorySystem</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a56c01b71d257ca4b3c46867ebb7710ef8535e5f5767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a56c01b71d257ca4b3c46867ebb7710ef8535e5f6945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a56c01b71d257ca4b3c46867ebb7710ef8535e5f8123", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
   ViewData["Title"] = "Title"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center \" style=\"margin-top: 50px\">\r\n    <h2 class=\"text-primary\">Retrival List</h2>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <table class=""table"" id=""dataTable"">
            <thead>
                <tr>
                    <th>Agent Name</th>
                    <th>Name Of Equipment Retrieved</th>
                    <th>Name Of Agent Re-Assigned To</th>
                    <th>Date Retrieved</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                   Write(obj.NameOfAgent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                   Write(obj.NameOfEquipmentRetrieved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                     if (obj.NameOfAgentReassignedTo == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><p class=\"text-danger\"> empty </p></td>\r\n");
#nullable restore
#line 48 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 51 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                       Write(obj.NameOfAgentReassignedTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
                   Write(obj.DateRetrieved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"



                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 76 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"


   


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> Oops No Retrival  Yet</p>\r\n");
#nullable restore
#line 85 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Retrival\GetAllRetrievedEquipment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocalBetBiga.Models.Entities.Retrival>> Html { get; private set; }
    }
}
#pragma warning restore 1591
