#pragma checksum "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a84f1b3802ee34c9b327ae172ff26b4ffa36f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PedidosDetalle), @"mvc.1.0.view", @"/Views/Shared/_PedidosDetalle.cshtml")]
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
#line 1 "C:\demoMVC\Demo.Sopra.MVC\Views\_ViewImports.cshtml"
using Demo.Sopra.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\demoMVC\Demo.Sopra.MVC\Views\_ViewImports.cshtml"
using Demo.Sopra.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a84f1b3802ee34c9b327ae172ff26b4ffa36f8", @"/Views/Shared/_PedidosDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d3d3875967f0ad419fcfe2242e6998fff7de8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PedidosDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order_Detail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n");
#nullable restore
#line 4 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <span class=\"text-right\"><b>Nombre:</b> ");
#nullable restore
#line 7 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
                                               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"text-right\"><b>Nombre:</b> ");
#nullable restore
#line 8 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"text-right\"><b>Nombre:</b> ");
#nullable restore
#line 9 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
                                               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"text-right\"><b>Nombre:</b> ");
#nullable restore
#line 10 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
                                                Write(item.UnitPrice * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </tr>\r\n");
#nullable restore
#line 12 "C:\demoMVC\Demo.Sopra.MVC\Views\Shared\_PedidosDetalle.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order_Detail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
