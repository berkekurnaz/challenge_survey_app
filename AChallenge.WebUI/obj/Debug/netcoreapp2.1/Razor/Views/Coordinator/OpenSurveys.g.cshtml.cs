#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320c0a439015010996a67afc0c2f0d7230d4077e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordinator_OpenSurveys), @"mvc.1.0.view", @"/Views/Coordinator/OpenSurveys.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coordinator/OpenSurveys.cshtml", typeof(AspNetCore.Views_Coordinator_OpenSurveys))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320c0a439015010996a67afc0c2f0d7230d4077e", @"/Views/Coordinator/OpenSurveys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordinator_OpenSurveys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AChallenge.Models.Concrete.Survey>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
  
    ViewData["Title"] = "OpenSurveys";
    Layout = "~/Views/Shared/_LayoutCoordinator.cshtml";

#line default
#line hidden
            BeginContext(160, 178, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Open Surveys</h2>\r\n<p class=\"text-center\">You can see all open surveys in our platform.</p>\r\n<hr />\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 13 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
         if (TempData["MsgSuccess"] != null)
        {

#line default
#line hidden
            BeginContext(395, 45, true);
            WriteLiteral("            <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(441, 22, false);
#line 15 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                                        Write(TempData["MsgSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(463, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 16 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
        }

#line default
#line hidden
            BeginContext(482, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 17 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(526, 585, true);
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered dataTable"" id=""dataTable"" width=""100%"" cellspacing=""0"" role=""grid"" aria-describedby=""dataTable_info"" style=""width: 100%;"">
                    <thead>
                        <tr role=""row"">
                            <th>Id</th>
                            <th>Created Date</th>
                            <th>Is Visible</th>
                            <th>Detail</th>
                        </tr>
                    </thead>
                    <tbody class=""text-center"">
");
            EndContext();
#line 30 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                         foreach (var item in Model)
                        {
                            var tm = "#ModalEdit" + item.Id;
                            var mid = "ModalEdit" + item.Id;


#line default
#line hidden
            BeginContext(1318, 93, true);
            WriteLiteral("                            <tr role=\"row\" class=\"odd\">\r\n                                <td>");
            EndContext();
            BeginContext(1412, 7, false);
#line 36 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1463, 16, false);
#line 37 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                               Write(item.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1523, 14, false);
#line 38 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                               Write(item.IsVisible);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 83, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1659, 2);
            WriteAttributeValue("", 1627, "/Coordinator/OpenSurvey/", 1627, 24, true);
#line 40 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
WriteAttributeValue("", 1651, item.Id, 1651, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1660, 124, true);
            WriteLiteral(" class=\"btn btn-success btn-sm\">Show Details</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
                        }

#line default
#line hidden
            BeginContext(1811, 76, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
            EndContext();
#line 47 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1923, 70, true);
            WriteLiteral("            <h4 class=\"text-center\">You didn\'t add a survey yet</h4>\r\n");
            EndContext();
#line 51 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\OpenSurveys.cshtml"
        }

#line default
#line hidden
            BeginContext(2004, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2026, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42187f14ad14fe4b578c2224db43a32", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2079, 107, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#dataTable\').DataTable();\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AChallenge.Models.Concrete.Survey>> Html { get; private set; }
    }
}
#pragma warning restore 1591
