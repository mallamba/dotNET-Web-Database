#pragma checksum "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "187973cb3538013087814e6ef0f02ad1ffb4ab0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItmlistFromSession), @"mvc.1.0.view", @"/Views/Home/ItmlistFromSession.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ItmlistFromSession.cshtml", typeof(AspNetCore.Views_Home_ItmlistFromSession))]
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
#line 1 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187973cb3538013087814e6ef0f02ad1ffb4ab0b", @"/Views/Home/ItmlistFromSession.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItmlistFromSession : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
  
    ViewData["Title"] = "ItmlistFromSession";

#line default
#line hidden
            BeginContext(105, 42, true);
            WriteLiteral("\r\n<h1>ItmlistFromSession</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187973cb3538013087814e6ef0f02ad1ffb4ab0b3972", async() => {
                BeginContext(170, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(184, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(227, 14, true);
            WriteLiteral("<ul>\r\n    <li>");
            EndContext();
            BeginContext(242, 38, false);
#line 16 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(280, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(283, 37, false);
#line 16 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(320, 19, true);
            WriteLiteral("    </li>\r\n    <li>");
            EndContext();
            BeginContext(340, 40, false);
#line 17 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(380, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(383, 39, false);
#line 17 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(422, 18, true);
            WriteLiteral("    </li>\r\n</ul>\r\n");
            EndContext();
#line 19 "C:\Users\Mallamba\source\repos\WebApplication3\WebApplication3\Views\Home\ItmlistFromSession.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
