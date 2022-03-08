#pragma checksum "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505065ba7dc0a3c24ea81e036dca1f5dac3e3a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publication_DetailsbyFaculty), @"mvc.1.0.view", @"/Views/Publication/DetailsbyFaculty.cshtml")]
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
#line 1 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/_ViewImports.cshtml"
using FacultyInformationSystem_MVCCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/_ViewImports.cshtml"
using FacultyInformationSystem_MVCCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505065ba7dc0a3c24ea81e036dca1f5dac3e3a0a", @"/Views/Publication/DetailsbyFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c2735c7c200cfef20ebfd27dfb944ce8ac07f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Publication_DetailsbyFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FacultyInformationSystem_MVCCore.Publication>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
  
    ViewData["Title"] = "Publication Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.PublicationTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 47 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublicationTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArticleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 62 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Publication", new { id = item.PublicationId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 63 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
           Write(Html.ActionLink("Details", "Details", "Publication", new { id = item.PublicationId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/DetailsbyFaculty.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FacultyInformationSystem_MVCCore.Publication>> Html { get; private set; }
    }
}
#pragma warning restore 1591