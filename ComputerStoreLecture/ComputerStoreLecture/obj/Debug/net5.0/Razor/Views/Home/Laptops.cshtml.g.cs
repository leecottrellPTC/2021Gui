#pragma checksum "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f54caa8b5378407f05a2e5ca2d355f561ed91dbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Laptops), @"mvc.1.0.view", @"/Views/Home/Laptops.cshtml")]
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
#line 1 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54caa8b5378407f05a2e5ca2d355f561ed91dbc", @"/Views/Home/Laptops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b7d9c611cb59decfb0a94c07eaee0ff3aa087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Laptops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
  
    ViewData["Title"] = "Laptops";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Laptops</h1>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Price</th>
            <th>RAM</th>
            <th>Screen</th>
            <th>Weight</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
         foreach (Laptop rig in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
               Write(rig.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
               Write(rig.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
               Write(rig.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
               Write(rig.Screen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
               Write(rig.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\lee_c\source\ASP 2021\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Laptops.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n");
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
