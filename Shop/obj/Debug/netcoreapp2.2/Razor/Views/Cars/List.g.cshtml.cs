#pragma checksum "E:\ProgTest\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842d034af6012af6fbfd121b886d57eac80e5cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "E:\ProgTest\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "E:\ProgTest\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842d034af6012af6fbfd121b886d57eac80e5cf8", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
            EndContext();
            BeginContext(30, 18, false);
#line 2 "E:\ProgTest\Shop\Shop\Views\Cars\List.cshtml"
Write(Model.CurrCategory);

#line default
#line hidden
            EndContext();
            BeginContext(48, 36, true);
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "E:\ProgTest\Shop\Shop\Views\Cars\List.cshtml"
      
        foreach (Car car in Model.AllCars)
        {
            

#line default
#line hidden
            BeginContext(160, 28, false);
#line 7 "E:\ProgTest\Shop\Shop\Views\Cars\List.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
            EndContext();
#line 7 "E:\ProgTest\Shop\Shop\Views\Cars\List.cshtml"
                                         
        }
    

#line default
#line hidden
            BeginContext(208, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
