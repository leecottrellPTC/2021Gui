#pragma checksum "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a319c7eacf348c6e862e48f88b3135e1064183f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Desktops), @"mvc.1.0.view", @"/Views/Home/Desktops.cshtml")]
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
#line 1 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a319c7eacf348c6e862e48f88b3135e1064183f", @"/Views/Home/Desktops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b7d9c611cb59decfb0a94c07eaee0ff3aa087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Desktops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
   ViewData["Title"] = "Desktops";
                SiteData globals = new SiteData(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Desktops</h1>\r\n<h3>Setup costs for laptops are ");
#nullable restore
#line 6 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
                           Write(globals.setup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>We offer 24x7 support. For help reach out to ");
#nullable restore
#line 7 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
                                           Write(globals.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Price</th>\r\n            <th>RAM</th>\r\n            <th>Price with tax</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
         foreach (Desktop rig in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
           Write(rig.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
            Write($"{(rig.Price):C2}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
           Write(rig.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
            Write($"{(rig.Price * (globals.tax + 1)):C2}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>            ");
#nullable restore
#line 25 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Desktops.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
