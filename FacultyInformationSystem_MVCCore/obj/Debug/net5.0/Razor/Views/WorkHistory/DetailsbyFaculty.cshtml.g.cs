#pragma checksum "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2234bff8e7c00489c59146cfb89fec2705d44622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkHistory_DetailsbyFaculty), @"mvc.1.0.view", @"/Views/WorkHistory/DetailsbyFaculty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2234bff8e7c00489c59146cfb89fec2705d44622", @"/Views/WorkHistory/DetailsbyFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c2735c7c200cfef20ebfd27dfb944ce8ac07f1", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkHistory_DetailsbyFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FacultyInformationSystem_MVCCore.WorkHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
  
    ViewData["Title"] = "Work History Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 31 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.JobResponsibilities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.JobType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 50 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.DisplayFor(modelItem => item.Organization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 62 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobResponsibilities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.ActionLink("Edit", "Edit","WorkHistory", new { id = item.WorkHistoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 69 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
               Write(Html.ActionLink("Details", "Details","WorkHistory", new { id = item.WorkHistoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/WorkHistory/DetailsbyFaculty.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FacultyInformationSystem_MVCCore.WorkHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591