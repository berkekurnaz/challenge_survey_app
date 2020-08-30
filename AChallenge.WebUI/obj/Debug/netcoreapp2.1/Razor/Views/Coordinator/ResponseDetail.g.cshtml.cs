#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97cee6ead4186be6a3d0f9d1f2288b729025b884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordinator_ResponseDetail), @"mvc.1.0.view", @"/Views/Coordinator/ResponseDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coordinator/ResponseDetail.cshtml", typeof(AspNetCore.Views_Coordinator_ResponseDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97cee6ead4186be6a3d0f9d1f2288b729025b884", @"/Views/Coordinator/ResponseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordinator_ResponseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AChallenge.Models.Concrete.Response>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
  
    ViewData["Title"] = "ResponseDetail";
    Layout = "~/Views/Shared/_LayoutCoordinator.cshtml";

#line default
#line hidden
            BeginContext(152, 125, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body text-center\">\r\n        <h4>Response Detail</h4>\r\n        <hr />\r\n        <h5>");
            EndContext();
            BeginContext(278, 23, false);
#line 11 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
       Write(ViewBag.FindSurveyTitle);

#line default
#line hidden
            EndContext();
            BeginContext(301, 54, true);
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
      
        int qNumber = 1;
    

#line default
#line hidden
            BeginContext(396, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 19 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
     foreach (var item in Model.Answers)
    {

#line default
#line hidden
            BeginContext(445, 152, true);
            WriteLiteral("    <div class=\"col-md-6\">\r\n        <div class=\"card\" style=\"margin-bottom:25px\">\r\n            <div class=\"card-body\">\r\n                <h6><b>Question-");
            EndContext();
            BeginContext(598, 7, false);
#line 24 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                           Write(qNumber);

#line default
#line hidden
            EndContext();
            BeginContext(605, 6, true);
            WriteLiteral(":</b> ");
            EndContext();
            BeginContext(612, 35, false);
#line 24 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                                         Write(ViewBag.FindSurvey[qNumber-1].Title);

#line default
#line hidden
            EndContext();
            BeginContext(647, 53, true);
            WriteLiteral("</h6>\r\n                <hr />\r\n                <ul>\r\n");
            EndContext();
#line 27 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                     foreach (var qOption in @ViewBag.FindSurvey[qNumber - 1].Options)
                    {
                        if (qOption == item)
                        {

#line default
#line hidden
            BeginContext(884, 35, true);
            WriteLiteral("                            <li><b>");
            EndContext();
            BeginContext(920, 7, false);
#line 31 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                              Write(qOption);

#line default
#line hidden
            EndContext();
            BeginContext(927, 11, true);
            WriteLiteral("</b></li>\r\n");
            EndContext();
#line 32 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1022, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(1055, 7, false);
#line 35 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                           Write(qOption);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 36 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1119, 89, true);
            WriteLiteral("                </ul>\r\n                <hr />\r\n            <p><b>Respondent Answer: </b> ");
            EndContext();
            BeginContext(1209, 4, false);
#line 40 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
                                     Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 46, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    </div>\r\n");
            EndContext();
#line 44 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\ResponseDetail.cshtml"
        qNumber++;
    }

#line default
#line hidden
            BeginContext(1286, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AChallenge.Models.Concrete.Response> Html { get; private set; }
    }
}
#pragma warning restore 1591
