#pragma checksum "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2879ffb041429c4c3d47382a81f243991372314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordinator_Index), @"mvc.1.0.view", @"/Views/Coordinator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coordinator/Index.cshtml", typeof(AspNetCore.Views_Coordinator_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2879ffb041429c4c3d47382a81f243991372314", @"/Views/Coordinator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordinator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutCoordinator.cshtml";

#line default
#line hidden
            BeginContext(101, 850, true);
            WriteLiteral(@"
<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
    <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm""><i class=""fas fa-download fa-sm text-white-50""></i> Generate Report</a>
</div>

<!-- Content Row -->
<div class=""row"">

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Open Survey</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(952, 18, false);
#line 23 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml"
                                                                       Write(ViewBag.Statistic1);

#line default
#line hidden
            EndContext();
            BeginContext(970, 749, true);
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Your Survey</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1720, 18, false);
#line 40 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml"
                                                                       Write(ViewBag.Statistic2);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 893, true);
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Total Response Count</div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(2632, 18, false);
#line 59 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml"
                                                                                    Write(ViewBag.Statistic3);

#line default
#line hidden
            EndContext();
            BeginContext(2650, 829, true);
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Pending Requests Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Your Response Count</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(3480, 18, false);
#line 78 "C:\Users\Berke\source\repos\AChallenge\AChallenge.WebUI\Views\Coordinator\Index.cshtml"
                                                                       Write(ViewBag.Statistic4);

#line default
#line hidden
            EndContext();
            BeginContext(3498, 267, true);
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-comments fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
