#pragma checksum "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c73f90227c185acbb9969bda3c83abc5683774f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73f90227c185acbb9969bda3c83abc5683774f1", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b7d9c611cb59decfb0a94c07eaee0ff3aa087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerStoreLecture.Models.OrderItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thanks for your order</h1>\r\n<p>You ordered a computer. The price and specs will be emailed to ");
#nullable restore
#line 7 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h2>Specifications</h2>\r\n<ul>\r\n    <li>Processor = ");
#nullable restore
#line 11 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
               Write(Model.Processor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Speed = ");
#nullable restore
#line 12 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
           Write(Model.Speed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ghz </li>\r\n    <li>RAM = ");
#nullable restore
#line 13 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
         Write(Model.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</li>\r\n    <li>Hard Drive = ");
#nullable restore
#line 14 "D:\source\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
                Write(Model.HDSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TB</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerStoreLecture.Models.OrderItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
