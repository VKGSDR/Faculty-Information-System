#pragma checksum "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab86806920660c36450c386db9ddea0fdf722bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_AdminProfile), @"mvc.1.0.view", @"/Views/Auth/AdminProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab86806920660c36450c386db9ddea0fdf722bdf", @"/Views/Auth/AdminProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c2735c7c200cfef20ebfd27dfb944ce8ac07f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_AdminProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
  
    //ViewData.Title = "Faculty Information System";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1>Hello Admin</h1>\r\n        <h2 class=\"display-4\">Welcome to Faculty Information System</h2>\r\n\r\n    </div>\r\n");
            WriteLiteral("<hr />\r\n<div>\r\n    <ul class=\"list-group\">\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-info\">");
#nullable restore
#line 15 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
                                                  Write(Html.ActionLink("Faculty Personal Information", "Index", "Faculty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-primary\">\r\n                ");
#nullable restore
#line 19 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Department", "Index", "Department Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <style>
                    a {
                        color: #FFFFFF;
                    }
                </style>
            </button>
        </li>
        <li class=""list-group-item"">
            <button type=""button"" class=""btn btn-secondary"">
                ");
#nullable restore
#line 29 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Course Information", "Index", "Course"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-success\">\r\n                ");
#nullable restore
#line 34 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Subject Information", "Index", "Subject"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-danger\">\r\n                ");
#nullable restore
#line 39 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Designation Information", "Index", "Designation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-warning\">\r\n                ");
#nullable restore
#line 44 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Publication Information", "Index", "Publication"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-info\">\r\n                ");
#nullable restore
#line 49 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Grant Information", "Index", "Grant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <button type=\"button\" class=\"btn btn-info\">\r\n                ");
#nullable restore
#line 54 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Auth/AdminProfile.cshtml"
           Write(Html.ActionLink("Work History Information", "Index", "WorkHistory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </li>\r\n    </ul>\r\n    \r\n</div>\r\n");
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