#pragma checksum "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec39ecb6b182749bc2f9194748a67f1cca619d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Go_Details), @"mvc.1.0.view", @"/Views/Go/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Go/Details.cshtml", typeof(AspNetCore.Views_Go_Details))]
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
#line 1 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\_ViewImports.cshtml"
using Pokemon;

#line default
#line hidden
#line 2 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\_ViewImports.cshtml"
using Pokemon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec39ecb6b182749bc2f9194748a67f1cca619d1", @"/Views/Go/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2c26f876c2c184762a06dc7dd097b1e06b82a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Go_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Go>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(56, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Go</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(182, 43, false);
#line 14 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pokemon));

#line default
#line hidden
            EndContext();
            BeginContext(225, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(289, 42, false);
#line 17 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pokemon.Id));

#line default
#line hidden
            EndContext();
            BeginContext(331, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(394, 40, false);
#line 20 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Seen));

#line default
#line hidden
            EndContext();
            BeginContext(434, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(498, 36, false);
#line 23 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Seen));

#line default
#line hidden
            EndContext();
            BeginContext(534, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(597, 42, false);
#line 26 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Caught));

#line default
#line hidden
            EndContext();
            BeginContext(639, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(703, 38, false);
#line 29 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Caught));

#line default
#line hidden
            EndContext();
            BeginContext(741, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(804, 41, false);
#line 32 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lucky));

#line default
#line hidden
            EndContext();
            BeginContext(845, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(909, 37, false);
#line 35 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lucky));

#line default
#line hidden
            EndContext();
            BeginContext(946, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1009, 41, false);
#line 38 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Shiny));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1114, 37, false);
#line 41 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Shiny));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1214, 42, false);
#line 44 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Shadow));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1320, 38, false);
#line 47 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
       Write(Html.DisplayFor(model => model.Shadow));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1405, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec39ecb6b182749bc2f9194748a67f1cca619d19575", async() => {
                BeginContext(1451, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\Pokemon\Pokemon\Views\Go\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1459, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1467, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec39ecb6b182749bc2f9194748a67f1cca619d111919", async() => {
                BeginContext(1489, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1505, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Go> Html { get; private set; }
    }
}
#pragma warning restore 1591