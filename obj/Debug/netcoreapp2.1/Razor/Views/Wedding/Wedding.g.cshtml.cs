#pragma checksum "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe02796a9884bd38274036eef839e62ffe0680a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WeddingPlanner.Wedding.Views_Wedding_Wedding), @"mvc.1.0.view", @"/Views/Wedding/Wedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Wedding.cshtml", typeof(WeddingPlanner.Wedding.Views_Wedding_Wedding))]
namespace WeddingPlanner.Wedding
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe02796a9884bd38274036eef839e62ffe0680a", @"/Views/Wedding/Wedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ba80ab251ef57f766eef041eef7409dc83162a", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Wedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingPlanner.Models.Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WeddingNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(65, 868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33f10f53cbee425c9f40712281c5e824", async() => {
                BeginContext(71, 726, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Wedding</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    
    <!-- Bootstrap library -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

    <!-- Add icon library -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">   
    
    <!-- Local Style Sheet -->
    ");
                EndContext();
                BeginContext(797, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "707bebd45ea04b40878788d234d4317f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(875, 51, true);
                WriteLiteral("\r\n\r\n     <!-- <script src=\"main.js\"></script> -->\r\n");
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
            BeginContext(933, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(935, 6860, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6e48bed4334c7d951c917bd3a1f221", async() => {
                BeginContext(941, 451, true);
                WriteLiteral(@"
    <div class=""container  border bkgd-lightblue"">

        <!-- Main: Begin -->
        <div class=""row"">
            <div class=""col-sm-12 col-md-2 col-lg-2""></div>
            <div class=""col-sm-12 col-md-8 col-lg-8 wp-box wp-box-4"">

                <!-- Title form: Begin -->
                <div class=""row"">
                    <div class=""col-sm-12 col-md-10 col-lg-10"">
                        <h3>Welcome to the Wedding Planner, ");
                EndContext();
                BeginContext(1393, 29, false);
#line 35 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                                       Write(ViewBag.LoggedInUserFirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1422, 177, true);
                WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"col-sm-12 col-md-2 col-lg-2\">\r\n                        <div class=\"ml-10 mt-20\">\r\n                            ");
                EndContext();
                BeginContext(1599, 296, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5ed1fe4ea441cd9bf8e8111b9f669f", async() => {
                    BeginContext(1661, 227, true);
                    WriteLiteral("\r\n                                <div class=\"form-actions\">\r\n                                    <button type=\"submit\" class=\"btn  btn-link\">Logout</button>\r\n                                </div>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
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
                BeginContext(1895, 1200, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <!-- Title form: Ends -->

                <!-- Table of Weddings: Begin -->
                <div class=""row mt-10"">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""responsive tbl-scroll"">
                            <table class=""table table-bordered table-striped table-hover table-condensed table-fixed"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Wedding</th>
                                        <th scope=""col"">Date</th>
                                        <th scope=""col"">Guests</th>
                                        <th scope=""col"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- Link below has info on a tag a");
                WriteLiteral("sp routing -->\r\n                                    <!-- https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/anchor-tag-helper?view=aspnetcore-2.2 -->\r\n");
                EndContext();
#line 65 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                     foreach(var wedding in @ViewBag.AllWeddings)
                                    {

#line default
#line hidden
                BeginContext(3217, 158, true);
                WriteLiteral("                                        <tr>\r\n                                            <!-- Wedding -->\r\n                                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3375, "\"", 3419, 2);
                WriteAttributeValue("", 3382, "/wedding/guestlist/", 3382, 19, true);
#line 69 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
WriteAttributeValue("", 3401, wedding.WeddingId, 3401, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3420, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3422, 29, false);
#line 69 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                                                                           Write(wedding.WedderOneTwoFirstName);

#line default
#line hidden
                EndContext();
                BeginContext(3451, 120, true);
                WriteLiteral("</a></td>\r\n\r\n                                            <!-- Date -->\r\n                                            <td>");
                EndContext();
                BeginContext(3572, 43, false);
#line 72 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                           Write(wedding.WeddingDate.ToString("MMM dd yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3615, 118, true);
                WriteLiteral("</td>\r\n\r\n                                            <!-- Guests -->\r\n                                            <td>");
                EndContext();
                BeginContext(3734, 18, false);
#line 75 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                           Write(wedding.GuestCount);

#line default
#line hidden
                EndContext();
                BeginContext(3752, 70, true);
                WriteLiteral("</td>\r\n\r\n                                            <!-- Action -->\r\n");
                EndContext();
#line 78 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                              string loggedInUserId = @ViewBag.LoggedInUserId.ToString()+",";

#line default
#line hidden
                BeginContext(3934, 44, true);
                WriteLiteral("                                            ");
                EndContext();
#line 79 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                             if( @ViewBag.LoggedInUserId == @wedding.CreatorUserId)
                                             {

#line default
#line hidden
                BeginContext(4083, 157, true);
                WriteLiteral("                                                 <!-- Delete Wedding -->\r\n                                                 <!-- <td><a href=\"/Wedding/delete/");
                EndContext();
                BeginContext(4241, 17, false);
#line 82 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                                                              Write(wedding.WeddingId);

#line default
#line hidden
                EndContext();
                BeginContext(4258, 131, true);
                WriteLiteral("\">Delete</a></td> -->\r\n                                                 <td>\r\n                                                     ");
                EndContext();
                BeginContext(4389, 398, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76739733c6494689892ff6666e81db59", async() => {
                    BeginContext(4453, 327, true);
                    WriteLiteral(@"
                                                         <div class=""form-actions"">
                                                             <button type=""submit"" class=""btn  btn-link"">Delete</button>
                                                         </div>
                                                     ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4403, "/wedding/delete/", 4403, 16, true);
#line 84 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
AddHtmlAttributeValue("", 4419, wedding.WeddingId, 4419, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                BeginContext(4787, 58, true);
                WriteLiteral("\r\n                                                 </td>\r\n");
                EndContext();
#line 90 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                             }
                                             else if(@wedding.GuestIds.Contains(loggedInUserId))
                                             {

#line default
#line hidden
                BeginContext(5039, 227, true);
                WriteLiteral("                                                 <!-- Un-RSVP:  Remove current user from this weddings guest list -->\r\n                                                 <td>\r\n                                                     ");
                EndContext();
                BeginContext(5266, 421, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b81d657168145e5a2fb5b8489d0b33b", async() => {
                    BeginContext(5352, 328, true);
                    WriteLiteral(@"
                                                         <div class=""form-actions"">
                                                             <button type=""submit"" class=""btn  btn-link"">Un-RSVP</button>
                                                         </div>
                                                     ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5280, "/guest/unrsvp/", 5280, 14, true);
#line 95 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
AddHtmlAttributeValue("", 5294, wedding.WeddingId, 5294, 18, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 5312, "/", 5312, 1, true);
#line 95 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
AddHtmlAttributeValue("", 5313, ViewBag.LoggedInUserId, 5313, 23, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                BeginContext(5687, 58, true);
                WriteLiteral("\r\n                                                 </td>\r\n");
                EndContext();
#line 101 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                             }
                                             else
                                             {

#line default
#line hidden
                BeginContext(5892, 223, true);
                WriteLiteral("                                                 <!-- RSVP:  Add the current user to this weddings guest list -->\r\n                                                 <td>\r\n                                                     ");
                EndContext();
                BeginContext(6115, 416, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f315223f9b944fcb8d83843b177cc50", async() => {
                    BeginContext(6199, 325, true);
                    WriteLiteral(@"
                                                         <div class=""form-actions"">
                                                             <button type=""submit"" class=""btn  btn-link"">RSVP</button>
                                                         </div>
                                                     ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6129, "/guest/rsvp/", 6129, 12, true);
#line 106 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
AddHtmlAttributeValue("", 6141, wedding.WeddingId, 6141, 18, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 6159, "/", 6159, 1, true);
#line 106 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
AddHtmlAttributeValue("", 6160, ViewBag.LoggedInUserId, 6160, 23, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                BeginContext(6531, 58, true);
                WriteLiteral("\r\n                                                 </td>\r\n");
                EndContext();
#line 112 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                             }

#line default
#line hidden
                BeginContext(6637, 47, true);
                WriteLiteral("                                        </tr>\r\n");
                EndContext();
#line 114 "D:\CodingDojo\DotNet\04_ORMs\04_EntityFramework\15_WeddingPlanner\WeddingPlanner\Views\Wedding\Wedding.cshtml"
                                    }

#line default
#line hidden
                BeginContext(6723, 512, true);
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Table of Weddings: Ends -->

                <!-- New Weddinb Button: Begins -->
                <div class=""row mt-20"">
                    <div class=""col-sm-12 col-md-9 col-lg-9""></div>
                    <div class=""col-sm-12 col-md-2 col-lg-2"">
                        <!-- Edit button -->
                        ");
                EndContext();
                BeginContext(7235, 313, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91174e248c16458d8fd05899f8e67ab5", async() => {
                    BeginContext(7304, 237, true);
                    WriteLiteral("\r\n                            <div class=\"text-center\">\r\n                                <button type=\"submit\" class=\"btn btn-primary\">New Wedding</button>\r\n                            </div>                    \r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7548, 240, true);
                WriteLiteral("\r\n                    </div>\r\n                <div class=\"col-sm-12 col-md-1 col-lg-1\">                \r\n                <!-- New Weddinb Button: Ends -->\r\n\r\n\r\n             </div>\r\n        </div>\r\n        <!-- Main: Ends -->\r\n\r\n    </div>\r\n");
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
            BeginContext(7795, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingPlanner.Models.Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
