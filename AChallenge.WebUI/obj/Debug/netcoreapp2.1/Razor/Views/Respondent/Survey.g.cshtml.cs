#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6dc62973f48ba5df430bb308271b42d28a5d15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Respondent_Survey), @"mvc.1.0.view", @"/Views/Respondent/Survey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Respondent/Survey.cshtml", typeof(AspNetCore.Views_Respondent_Survey))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6dc62973f48ba5df430bb308271b42d28a5d15", @"/Views/Respondent/Survey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Respondent_Survey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AChallenge.Models.Concrete.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Respondent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Survey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
  
    ViewData["Title"] = "Survey";
    Layout = "~/Views/Shared/_LayoutRespondent.cshtml";

#line default
#line hidden
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
 if (Model.Title != "ErrorCode202akfjryhskfhfgsgsgajskkf")
{

#line default
#line hidden
            BeginContext(206, 117, true);
            WriteLiteral("    <div>\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4><b>Survey Title: </b>");
            EndContext();
            BeginContext(324, 11, false);
#line 12 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(335, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(362, 17, false);
#line 13 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(379, 58, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div><br />\r\n\r\n        ");
            EndContext();
            BeginContext(437, 1767, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9411d2b242094ca29c3465df5b3558d6", async() => {
                BeginContext(530, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
              
                int questionNumber = 1;
                int questionSSS = 0;
                int optionNumber = 0;
            

#line default
#line hidden
                BeginContext(681, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 23 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
             foreach (var item in Model.Questions)
            {

#line default
#line hidden
                BeginContext(748, 123, true);
                WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <h6><b>Question-");
                EndContext();
                BeginContext(872, 14, false);
#line 27 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                   Write(questionNumber);

#line default
#line hidden
                EndContext();
                BeginContext(886, 6, true);
                WriteLiteral(": </b>");
                EndContext();
                BeginContext(893, 10, false);
#line 27 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                                        Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(903, 80, true);
                WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n");
                EndContext();
#line 30 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                         foreach (var option in item.Options)
                        {
                            optionNumber++;

#line default
#line hidden
                BeginContext(1118, 107, true);
                WriteLiteral("                            <div class=\"form-check\">\r\n\r\n                                <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1225, "\"", 1258, 3);
                WriteAttributeValue("", 1232, "radiovalue[", 1232, 11, true);
#line 35 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
WriteAttributeValue("", 1243, questionSSS, 1243, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1257, "]", 1257, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1259, "\"", 1290, 3);
                WriteAttributeValue("", 1264, "radiovalue[", 1264, 11, true);
#line 35 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
WriteAttributeValue("", 1275, questionSSS, 1275, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1289, "]", 1289, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1291, "\"", 1306, 1);
#line 35 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
WriteAttributeValue("", 1299, option, 1299, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1307, 116, true);
                WriteLiteral(" required />\r\n                                <label class=\"form-check-label\">\r\n                                    ");
                EndContext();
                BeginContext(1424, 6, false);
#line 37 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                               Write(option);

#line default
#line hidden
                EndContext();
                BeginContext(1430, 80, true);
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");
                EndContext();
#line 40 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"

                        }

#line default
#line hidden
                BeginContext(1539, 76, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n                <br />\r\n");
                EndContext();
#line 45 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                optionNumber++;
                questionNumber++;
                questionSSS++;
            }

#line default
#line hidden
                BeginContext(1730, 467, true);
                WriteLiteral(@"            <div class=""card"">
                <div class=""card-body"">
                    <div class=""form-group"">
                        <p class=""text-center""><b>Note: </b>If you complete this survey now, you will not be able to participate in this survey again.</p>
                        <center><button type=""submit"" class=""btn btn-info"">Send Survey</button></center>
                    </div>
                </div>
            </div><br />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2204, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 59 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2230, 360, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-body text-center"">
            <h4>Note</h4>
            <hr />
            <h5>Since you have participated in this survey before, you will not view it.</h5>
            <a href=""/Respondent/OpenSurveys/"" class=""btn btn-info"">Back to menu</a>
        </div>
    </div>
    <br />
    <div class=""row"">
");
            EndContext();
#line 72 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
           
            int qNumber = 1;
        

#line default
#line hidden
            BeginContext(2644, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 75 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
         foreach (var q2 in Model.Questions)
        {

#line default
#line hidden
            BeginContext(2701, 184, true);
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card\" style=\"margin-bottom:25px\">\r\n                    <div class=\"card-body\">\r\n                        <h6><b>Question-");
            EndContext();
            BeginContext(2886, 7, false);
#line 80 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                   Write(qNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2893, 6, true);
            WriteLiteral(":</b> ");
            EndContext();
            BeginContext(2900, 8, false);
#line 80 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                                 Write(q2.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 69, true);
            WriteLiteral("</h6>\r\n                        <hr />\r\n                        <ul>\r\n");
            EndContext();
#line 83 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                             foreach (var q2option in q2.Options)
                            {

#line default
#line hidden
            BeginContext(3075, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(3112, 8, false);
#line 85 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                               Write(q2option);

#line default
#line hidden
            EndContext();
            BeginContext(3120, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 86 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                            }

#line default
#line hidden
            BeginContext(3158, 111, true);
            WriteLiteral("                        </ul>\r\n                        <hr />\r\n                        <p><b>Your Answer: </b> ");
            EndContext();
            BeginContext(3270, 44, false);
#line 89 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
                                           Write(ViewBag.RespondentAnswers.Answers[qNumber-1]);

#line default
#line hidden
            EndContext();
            BeginContext(3314, 78, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 93 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"
            qNumber++;
        }

#line default
#line hidden
            BeginContext(3427, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 96 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Respondent\Survey.cshtml"

}

#line default
#line hidden
            BeginContext(3444, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3448, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a063d1674648aeb491962ab6850dfa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3501, 23, true);
            WriteLiteral("\r\n<script>\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AChallenge.Models.Concrete.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591