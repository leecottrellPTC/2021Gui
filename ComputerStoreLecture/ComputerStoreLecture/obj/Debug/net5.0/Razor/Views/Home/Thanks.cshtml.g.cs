#pragma checksum "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e609fc56648f86fcc1496a01cec306765069077c"
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
#line 1 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\_ViewImports.cshtml"
using ComputerStoreLecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e609fc56648f86fcc1496a01cec306765069077c", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83b59da9a299343b1627b42b00d12db984bdf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerStoreLecture.Models.OrderItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Thanks for your order</h1>\n<p>You ordered a computer. The price and specs will be emailed to ");
#nullable restore
#line 7 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<h2>Specifications</h2>\n<ul>\n    <li>Processor = ");
#nullable restore
#line 11 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
               Write(Model.Processor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Speed = ");
#nullable restore
#line 12 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
           Write(Model.Speed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ghz </li>\n    <li>RAM = ");
#nullable restore
#line 13 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
         Write(Model.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</li>\n    <li>Hard Drive = ");
#nullable restore
#line 14 "C:\Users\lee_c\source\GUI 2021\2021Gui\ComputerStoreLecture\ComputerStoreLecture\Views\Home\Thanks.cshtml"
                Write(Model.HDSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TB</li>\n</ul>\n");
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
