#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\SurveyQrCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ed1702302b66bb5a60dfa3e7888012ebcf641a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordinator_SurveyQrCode), @"mvc.1.0.view", @"/Views/Coordinator/SurveyQrCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coordinator/SurveyQrCode.cshtml", typeof(AspNetCore.Views_Coordinator_SurveyQrCode))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ed1702302b66bb5a60dfa3e7888012ebcf641a", @"/Views/Coordinator/SurveyQrCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordinator_SurveyQrCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Byte[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\SurveyQrCode.cshtml"
  
    ViewData["Title"] = "SurveyQrCode";
    Layout = null;

#line default
#line hidden
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\SurveyQrCode.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(109, 159, true);
            WriteLiteral("    <div class=\"row mt-3\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"col-md-3\"></div>\r\n            <div class=\"col-md-9\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 268, "\"", 348, 1);
#line 13 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\SurveyQrCode.cshtml"
WriteAttributeValue("", 274, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(Model)), 274, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(349, 78, true);
            WriteLiteral(" height=\"500\" width=\"500\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\SurveyQrCode.cshtml"
}

#line default
#line hidden
            BeginContext(430, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Byte[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
