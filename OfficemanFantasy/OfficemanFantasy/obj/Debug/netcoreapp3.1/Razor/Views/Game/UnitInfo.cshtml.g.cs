#pragma checksum "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\Game\UnitInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "371929d9189838eb1eb64233f2b6d057128681a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_UnitInfo), @"mvc.1.0.view", @"/Views/Game/UnitInfo.cshtml")]
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
#line 2 "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\_ViewImports.cshtml"
using OfficemanFantasy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371929d9189838eb1eb64233f2b6d057128681a4", @"/Views/Game/UnitInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed71ff5f3f94201d35e3e7e404d4308c945d8d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_UnitInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\Game\UnitInfo.cshtml"
  
    ViewData["Title"] = "UnitInfo";
    Unit unit = (Unit)ViewData["Unit"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>UnitInfo</h1>\r\n<h2>");
#nullable restore
#line 6 "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\Game\UnitInfo.cshtml"
Write(unit.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<img");
            BeginWriteAttribute("src", " src=", 131, "", 151, 1);
#nullable restore
#line 8 "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\Game\UnitInfo.cshtml"
WriteAttributeValue("", 136, unit.AvatarURL, 136, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<p>\r\n    Здоровье - ");
#nullable restore
#line 11 "C:\Users\Администратор\source\repos\IBA\OfficeGame\OfficemanFantasy\OfficemanFantasy\Views\Game\UnitInfo.cshtml"
          Write(unit.Health);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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