#pragma checksum "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6308513061441da8f1961d2fd28c4aac989c6db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Client), @"mvc.1.0.view", @"/Views/Home/Client.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Client.cshtml", typeof(AspNetCore.Views_Home_Client))]
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
#line 1 "G:\GitHub\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "G:\GitHub\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6308513061441da8f1961d2fd28c4aac989c6db", @"/Views/Home/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
  
    ViewData["Title"] = "Client";

#line default
#line hidden
            BeginContext(82, 23, true);
            WriteLiteral("\r\n<h1>Client</h1>\r\n\r\n\r\n");
            EndContext();
#line 10 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
  
	IEnumerable<WebApplication3.Models.Client> clients = ( IEnumerable<WebApplication3.Models.Client> ) ViewData["clients-in-list"];

#line default
#line hidden
            BeginContext(243, 65, true);
            WriteLiteral("\r\n\r\n<table>\r\n\r\n\t<tr>\r\n\t\t<th>Id </th>\r\n\t\t<th>Name</th>\r\n\t</tr>\r\n\r\n");
            EndContext();
#line 22 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
     foreach (Client client in clients) 
	{

#line default
#line hidden
            BeginContext(351, 15, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<th>");
            EndContext();
            BeginContext(367, 9, false);
#line 25 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
           Write(client.Id);

#line default
#line hidden
            EndContext();
            BeginContext(376, 14, true);
            WriteLiteral("</th>\r\n\t\t\t<th>");
            EndContext();
            BeginContext(391, 11, false);
#line 26 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
           Write(client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(402, 16, true);
            WriteLiteral("</th>\r\n\t\t</tr>\r\n");
            EndContext();
#line 28 "G:\GitHub\WebApplication3\WebApplication3\Views\Home\Client.cshtml"
	}

#line default
#line hidden
            BeginContext(422, 14, true);
            WriteLiteral("\r\n\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
