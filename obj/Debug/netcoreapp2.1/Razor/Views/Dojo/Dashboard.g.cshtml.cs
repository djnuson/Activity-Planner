#pragma checksum "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f64b2a8870897661b012113eca1258be3b1410c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dojo_Dashboard), @"mvc.1.0.view", @"/Views/Dojo/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dojo/Dashboard.cshtml", typeof(AspNetCore.Views_Dojo_Dashboard))]
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
#line 1 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
using DojoActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64b2a8870897661b012113eca1258be3b1410c9", @"/Views/Dojo/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdfec9d805dd1e79856c214e66b78fc3e086777", @"/Views/_ViewImports.cshtml")]
    public class Views_Dojo_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Participants>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JOIN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dojo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(81, 645, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd263da3c6e4877ae5175db20f55ee5", async() => {
                BeginContext(87, 440, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    ");
                EndContext();
                BeginContext(527, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e6e471bf10414ab3f93742cab58a8f", async() => {
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
                BeginContext(563, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(568, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "315fdc26a3a94773b2ad0c4cab80cb3b", async() => {
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
                BeginContext(618, 12, true);
                WriteLiteral("\n    <title>");
                EndContext();
                BeginContext(631, 13, false);
#line 15 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(644, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 16 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
          
            ViewBag.Title = "Welcome!";
        

#line default
#line hidden
                BeginContext(706, 13, true);
                WriteLiteral("    </title>\n");
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
            BeginContext(726, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(727, 2897, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "189bc3875b2b44fcbf91cb568c1dea5e", async() => {
                BeginContext(733, 240, true);
                WriteLiteral(" \n<h1 style=\"text-align: center;\"><strong>Dojo Activity Center</strong></h1>   \n<p style=\"text-align: center;\"><a  class=\"btn btn-danger\" href=\"/logout\">Logout</a></p><hr>\n    <h3 style=\"text-align: center;\">Hey <strong style=\"color: red;\">");
                EndContext();
                BeginContext(974, 13, false);
#line 24 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                               Write(ViewBag.fname);

#line default
#line hidden
                EndContext();
                BeginContext(987, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(989, 13, false);
#line 24 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                                              Write(ViewBag.lname);

#line default
#line hidden
                EndContext();
                BeginContext(1002, 579, true);
                WriteLiteral(@"</strong> ! 
    <br>Welcome!</h3>
    <!-- table -->
    <hr>
    <table id=""dtVerticalScrollExample"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                <th class=""th-sm"">Activity</th>
                <th class=""th-sm"">Date and time</th>
                <th class=""th-sm"">Duration</th>
                <th class=""th-sm"">Event Coordinator</th>
                <th class=""th-sm""># of Participants</th>
                <th class=""th-sm"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 40 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
              
                foreach (ActivityModel w in @ViewBag.allacts)
                {

#line default
#line hidden
                BeginContext(1676, 61, true);
                WriteLiteral("                <tr>\n                    <td> <a id=\"details\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1737, "\"", 1762, 2);
                WriteAttributeValue("", 1744, "/activity/", 1744, 10, true);
#line 44 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
WriteAttributeValue("", 1754, w.ActId, 1754, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1763, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1765, 7, false);
#line 44 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                              Write(w.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1772, 34, true);
                WriteLiteral("</a></td>\n                    <td>");
                EndContext();
                BeginContext(1807, 26, false);
#line 45 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                   Write(w.Date.ToString("MM/d @ "));

#line default
#line hidden
                EndContext();
                BeginContext(1833, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1835, 27, false);
#line 45 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                               Write(w.Time.ToString("hh:mm tt"));

#line default
#line hidden
                EndContext();
                BeginContext(1862, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1893, 10, false);
#line 46 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                   Write(w.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1903, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1905, 10, false);
#line 46 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                               Write(w.TimeForm);

#line default
#line hidden
                EndContext();
                BeginContext(1915, 51, true);
                WriteLiteral("</td>\n                    <td style=\"color:green;\">");
                EndContext();
                BeginContext(1967, 23, false);
#line 47 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                        Write(w.Coordinator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1990, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1992, 22, false);
#line 47 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                                 Write(w.Coordinator.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2014, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(2045, 19, false);
#line 48 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                   Write(w.participant.Count);

#line default
#line hidden
                EndContext();
                BeginContext(2064, 31, true);
                WriteLiteral("</td>\n                    <td>\n");
                EndContext();
#line 50 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                         if(@ViewBag.UserID == @w.UserId)
                        {

#line default
#line hidden
                BeginContext(2179, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2209, "\"", 2232, 2);
                WriteAttributeValue("", 2216, "/delete/", 2216, 8, true);
#line 52 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
WriteAttributeValue("", 2224, w.ActId, 2224, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2233, 36, true);
                WriteLiteral(" class=\"btn btn-primary\">Delete</a>\n");
                EndContext();
#line 53 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                        }

#line default
#line hidden
                BeginContext(2295, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 54 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                          
                            var count = 0;
                            foreach (var p in @w.participant)
                            {
                                if(@ViewBag.UserID == p.UserId)
                                {
                                    count++;
                                }
                            }
                            if (count == 0)
                            {

#line default
#line hidden
                BeginContext(2738, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2770, 386, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb3bf7eb4a44c4181e44cf96961874f", async() => {
                    BeginContext(2830, 37, true);
                    WriteLiteral("\n                                    ");
                    EndContext();
                    BeginContext(2867, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8b86ae959d147319291f204ba325bc4", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 66 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 66 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                                     WriteLiteral(ViewBag.UserID);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2929, 37, true);
                    WriteLiteral("\n                                    ");
                    EndContext();
                    BeginContext(2966, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad256617735d44288af9bb9a51bf7e30", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 67 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ActId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 67 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                                                                    WriteLiteral(w.ActId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3020, 129, true);
                    WriteLiteral("\n                                    <button class=\"btn btn-success\" type=\"submit\">JOIN</button>\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3156, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 70 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(3250, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3284, "\"", 3307, 2);
                WriteAttributeValue("", 3291, "/unjoin/", 3291, 8, true);
#line 73 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
WriteAttributeValue("", 3299, w.ActId, 3299, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3308, 34, true);
                WriteLiteral(" class=\"btn btn-danger\">LEAVE</a>\n");
                EndContext();
#line 74 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(3398, 62, true);
                WriteLiteral("                    </td>\n                </tr>              \n");
                EndContext();
#line 78 "/Users/nuson/Desktop/CSHARP/WEB/DojoActivity/Views/Dojo/Dashboard.cshtml"
                }
            

#line default
#line hidden
                BeginContext(3492, 125, true);
                WriteLiteral("        </tbody>\n    </table>\n    <hr>\n    <a class=\"btn btn-success\" href=\"/addactivity\" type=\"submit\">Add Activity</a><hr>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Participants> Html { get; private set; }
    }
}
#pragma warning restore 1591