#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45362c44ae7af0e0fcaea35fad507e6dbdf644b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prompts_Index), @"mvc.1.0.view", @"/Views/Prompts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prompts/Index.cshtml", typeof(AspNetCore.Views_Prompts_Index))]
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
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\_ViewImports.cshtml"
using WritingClub.Solution;

#line default
#line hidden
#line 2 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\_ViewImports.cshtml"
using WritingClub.Solution.Models;

#line default
#line hidden
#line 5 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
using WritingClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45362c44ae7af0e0fcaea35fad507e6dbdf644b0", @"/Views/Prompts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60af5d5b43ee3c329259de13da2cf854e210d806", @"/Views/_ViewImports.cshtml")]
    public class Views_Prompts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/prompts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 26, true);
            WriteLiteral("\r\n<h1>New Prompt:</h1>\r\n\r\n");
            EndContext();
            BeginContext(101, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45362c44ae7af0e0fcaea35fad507e6dbdf644b04574", async() => {
                BeginContext(139, 232, true);
                WriteLiteral("\r\n  <label for=\"title\">Prompt\'s Title</label>\r\n  <input id=\"title\" name=\"title\" type=\"text\">\r\n  <label for=\"content\">Prompt\'s Content</label>\r\n  <input id=\"content\" name=\"content\" type=\"text\">\r\n  <button type=\"submit\">Go!</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(378, 35, true);
            WriteLiteral("\r\n\r\n<h1>All Prompts:</h1>\r\n\r\n<ol>\r\n");
            EndContext();
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
 foreach (Prompt prompt in Model)
{

#line default
#line hidden
            BeginContext(451, 26, true);
            WriteLiteral("    <ul>\r\n        <li>ID: ");
            EndContext();
            BeginContext(478, 15, false);
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
           Write(prompt.PromptId);

#line default
#line hidden
            EndContext();
            BeginContext(493, 25, true);
            WriteLiteral("</li>\r\n        <li>Name: ");
            EndContext();
            BeginContext(519, 12, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
             Write(prompt.Title);

#line default
#line hidden
            EndContext();
            BeginContext(531, 24, true);
            WriteLiteral("</li>\r\n    </ul>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 555, "\"", 597, 2);
            WriteAttributeValue("", 562, "/Prompts/Details/", 562, 17, true);
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
WriteAttributeValue("", 579, prompt.PromptId, 579, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(598, 36, true);
            WriteLiteral("><p>View Details</p></a>\r\n    <br>\r\n");
            EndContext();
#line 28 "C:\Users\Stunning\Desktop\epicodusProjects\c#\WritingClub.Solution\WritingClub\Views\Prompts\Index.cshtml"
}

#line default
#line hidden
            BeginContext(637, 5, true);
            WriteLiteral("</ol>");
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
