#pragma checksum "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c13dfb6ed5cf21dbffb66ca24fa08eb7d95ded1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dojo_ShowActivity), @"mvc.1.0.view", @"/Views/Dojo/ShowActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dojo/ShowActivity.cshtml", typeof(AspNetCore.Views_Dojo_ShowActivity))]
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
#line 1 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/_ViewImports.cshtml"
using DojoActivity;

#line default
#line hidden
#line 1 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
using DojoActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13dfb6ed5cf21dbffb66ca24fa08eb7d95ded1c", @"/Views/Dojo/ShowActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdfec9d805dd1e79856c214e66b78fc3e086777", @"/Views/_ViewImports.cshtml")]
    public class Views_Dojo_ShowActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(82, 1046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afd6ef89322741a3ba0d0198ef36dfaa", async() => {
                BeginContext(88, 440, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    ");
                EndContext();
                BeginContext(528, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53590aeb750419495e35e0d97b8cf26", async() => {
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
                BeginContext(564, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(569, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1748628be0e94401b34b4712465974c6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(619, 12, true);
                WriteLiteral("\n    <title>");
                EndContext();
                BeginContext(632, 13, false);
#line 15 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(645, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 16 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
          
            ViewBag.Title = "Activity Details";
        

#line default
#line hidden
                BeginContext(715, 406, true);
                WriteLiteral(@"    </title>
    <style>
        .guests, .map {
            display: inline-block;
        }
        .guests, .map {
            margin-top: 20px;
            vertical-align: top;
        }
        .map {
            margin-left: 400px;
        }
        .description{
            outline:1px solid black;
            margin: 0 ;
            width: 300px;
            padding: 5px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1128, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1129, 1275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b255a5af78045af8159259820dc482a", async() => {
                BeginContext(1135, 363, true);
                WriteLiteral(@"
    <div class=""container"">
        <div>
            <h1 style=""text-align: center;""><strong>Dojo Activity Center</strong></h1>
            <p style=""text-align: center;""><a class=""btn btn-success"" href=""/dashboard"">Dashboard</a> <a class=""btn btn-danger"" href=""/logout"">Logout</a></p><hr>
            <h1 style=""text-align: center;""><strong style=""color:red;"">");
                EndContext();
                BeginContext(1499, 18, false);
#line 44 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                                                                  Write(ViewBag.show.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1517, 69, true);
                WriteLiteral("</strong></h1>        \n            <h3>Activity Coordinator: <strong>");
                EndContext();
                BeginContext(1587, 34, false);
#line 45 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                                         Write(ViewBag.show.Coordinator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1621, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1623, 33, false);
#line 45 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                                                                             Write(ViewBag.show.Coordinator.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1656, 271, true);
                WriteLiteral(@"</strong></h3>

<!-- need to grab user who created the activity and display his name and give a delete button function. -->


        </div>
        <hr>
            <h3 style=""color: green;"">Activity description:</h3>
        <div class=""description"">
            <p>=> ");
                EndContext();
                BeginContext(1928, 24, false);
#line 54 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
             Write(ViewBag.show.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1952, 84, true);
                WriteLiteral("</p>\n        </div>\n        <div class=\"guests\">\n            <h4>Participants:</h4>\n");
                EndContext();
                BeginContext(2051, 21, true);
                WriteLiteral("                <ul>\n");
                EndContext();
#line 60 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                     foreach (var g in @ViewBag.show.participant)
                    {

#line default
#line hidden
                BeginContext(2160, 48, true);
                WriteLiteral("                        <li style=\"color: red;\">");
                EndContext();
                BeginContext(2209, 16, false);
#line 62 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                                           Write(g.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2225, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2227, 15, false);
#line 62 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                                                             Write(g.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2242, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 63 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/ShowActivity.cshtml"
                    }

#line default
#line hidden
                BeginContext(2270, 22, true);
                WriteLiteral("                </ul>\n");
                EndContext();
                BeginContext(2306, 91, true);
                WriteLiteral("<!-- need to display Join/Leave buttons as on the dashboard. -->\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityModel> Html { get; private set; }
    }
}
#pragma warning restore 1591