#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3616cc59bb9e7f6d19c5db5a7e558b0dafa7a5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Respondent_JoinedSurveys), @"mvc.1.0.view", @"/Views/Respondent/JoinedSurveys.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Respondent/JoinedSurveys.cshtml", typeof(AspNetCore.Views_Respondent_JoinedSurveys))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3616cc59bb9e7f6d19c5db5a7e558b0dafa7a5c", @"/Views/Respondent/JoinedSurveys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Respondent_JoinedSurveys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AChallenge.Models.Concrete.Survey>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
  
    ViewData["Title"] = "JoinedSurveys";
    Layout = "~/Views/Shared/_LayoutRespondent.cshtml";

#line default
#line hidden
            BeginContext(161, 22, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n");
            EndContext();
#line 8 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
     if (TempData["MsgSuccess"] != null)
    {

#line default
#line hidden
            BeginContext(232, 41, true);
            WriteLiteral("        <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(274, 22, false);
#line 10 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
                                    Write(TempData["MsgSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(296, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 11 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
    }

#line default
#line hidden
            BeginContext(311, 121, true);
            WriteLiteral("    <div class=\"card-body\">\r\n        <h3 class=\"text-center\">Joined Surveys <span class=\"badge badge-pill badge-warning\">");
            EndContext();
            BeginContext(433, 13, false);
#line 13 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
                                                                                       Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(446, 174, true);
            WriteLiteral("</span></h3>\r\n        <hr />\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item active\">Surveys List - You can see all open surveys in this list.</li>\r\n");
            EndContext();
#line 17 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(677, 46, true);
            WriteLiteral("                <li class=\"list-group-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 723, "\"", 757, 2);
            WriteAttributeValue("", 730, "/Respondent/Survey/", 730, 19, true);
#line 19 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
WriteAttributeValue("", 749, item.Id, 749, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(758, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(760, 10, false);
#line 19 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
                                                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(770, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 20 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\JoinedSurveys.cshtml"
            }

#line default
#line hidden
            BeginContext(796, 37, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
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
