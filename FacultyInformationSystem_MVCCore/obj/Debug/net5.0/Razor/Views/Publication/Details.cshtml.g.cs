#pragma checksum "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "489a10b699c126a8508ae3cae861961754b8dfc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publication_Details), @"mvc.1.0.view", @"/Views/Publication/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489a10b699c126a8508ae3cae861961754b8dfc7", @"/Views/Publication/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c2735c7c200cfef20ebfd27dfb944ce8ac07f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Publication_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FacultyInformationSystem_MVCCore.Publication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""p-3 mb-2 bg-dark text-white""><h2>Details</h2></div>
<div>
    <hr />
    <p>
        <a class=""btn btn-secondary "" data-toggle=""collapse"" href=""#multiCollapseExample1"" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Show Less </a>
        <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample2"">More</button>
");
            WriteLiteral(@"    </p>
    <div class=""row"">
        <div class=""col"">
            <div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
                <div class=""card card-body"">
                    <p class=""font-weight-bold"">Title:</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 16 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.PublicationTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">Article:</p>\r\n                    <p>&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 18 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.ArticleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">Publisher: </p>\r\n                    <p>&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 20 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""collapse multi-collapse"" id=""multiCollapseExample2"">
                <div class=""card card-body"">
                    <p class=""font-weight-bold"">Publication ID:</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 28 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.PublicationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">Citation Date:</p>\r\n                    <p>&nbsp;&nbsp;&nbsp;&nbsp;");
#nullable restore
#line 30 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.CitationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">Publication Location:</p>\r\n                    <p>&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 32 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.PublicationLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 39 "/mnt/c/Vijay Kumar Gupta/FacultyInformationSystemWebAPI/FacultyInformationSystem_MVCCore/Views/Publication/Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.PublicationId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "489a10b699c126a8508ae3cae861961754b8dfc77818", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FacultyInformationSystem_MVCCore.Publication> Html { get; private set; }
    }
}
#pragma warning restore 1591
