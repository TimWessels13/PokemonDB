#pragma checksum "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816308f4bb0393763a97601c5b44e5437d1b2d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pokemons_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Pokemons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Pokemons/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Pokemons_Details))]
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
#line 1 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\_ViewImports.cshtml"
using Pokemon;

#line default
#line hidden
#line 2 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\_ViewImports.cshtml"
using Pokemon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816308f4bb0393763a97601c5b44e5437d1b2d35", @"/Areas/Admin/Views/Pokemons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288e505624ccf6f7bdb0883c2689c4dfa94cbd4d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pokemons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokemonView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
 foreach (var p in Model.Pokemon)
{


#line default
#line hidden
            BeginContext(107, 40, true);
            WriteLiteral("    <div class=\"float-left col-md-12\">\r\n");
            EndContext();
#line 11 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
         foreach (Color c in Model.Color)
        {
            if (c.Id == p.ColorId)
            {

#line default
#line hidden
            BeginContext(252, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 272, "\"", 292, 2);
            WriteAttributeValue("", 280, "card", 280, 4, true);
#line 15 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue(" ", 284, c.Name, 285, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 293, "\"", 325, 2);
            WriteAttributeValue("", 301, "background-color:", 301, 17, true);
#line 15 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 318, c.Name, 318, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 271, true);
            WriteLiteral(@">
                    <div class=""card-header"" style=""text-align: center;"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <h3 class=""float-right"">
                                    #
");
            EndContext();
#line 21 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     if (p.Number < 10)
                                    {
                                        var number = "00" + p.Number;
                                        

#line default
#line hidden
            BeginContext(805, 6, false);
#line 24 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                   Write(number);

#line default
#line hidden
            EndContext();
#line 24 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                               
                                    }
                                    else if (p.Number < 100)
                                    {
                                        var number = "0" + p.Number;
                                        

#line default
#line hidden
            BeginContext(1064, 6, false);
#line 29 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                   Write(number);

#line default
#line hidden
            EndContext();
#line 29 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                               
                                    }
                                    else if (p.Number < 1000)
                                    {
                                        var number = "" + p.Number;
                                        

#line default
#line hidden
            BeginContext(1323, 6, false);
#line 34 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                   Write(number);

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                               
                                    }
                                    else
                                    {
                                        var number = p.Number;
                                        

#line default
#line hidden
            BeginContext(1556, 6, false);
#line 39 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                   Write(number);

#line default
#line hidden
            EndContext();
#line 39 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                               
                                    }

#line default
#line hidden
            BeginContext(1603, 103, true);
            WriteLiteral("                                </h3>\r\n                                <h1 style=\"text-align: center;\">");
            EndContext();
            BeginContext(1707, 6, false);
#line 42 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                                           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1713, 243, true);
            WriteLiteral("</h1>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n");
            EndContext();
#line 49 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                 foreach (var g in Model.Gender)
                                {
                                    if (g.Id == p.GenderId)
                                    {

#line default
#line hidden
            BeginContext(2157, 52, true);
            WriteLiteral("                                        <p> Gender: ");
            EndContext();
            BeginContext(2210, 6, false);
#line 53 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                               Write(g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 54 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2296, 46, true);
            WriteLiteral("                                <p>Generation ");
            EndContext();
            BeginContext(2343, 12, false);
#line 56 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                         Write(p.Generation);

#line default
#line hidden
            EndContext();
            BeginContext(2355, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 57 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                 foreach (var col in Model.Color)
                                {
                                    if (col.Id == p.ColorId)
                                    {

#line default
#line hidden
            BeginContext(2564, 58, true);
            WriteLiteral("                                        <p>Pokedex color: ");
            EndContext();
            BeginContext(2623, 8, false);
#line 61 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                                     Write(col.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2631, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 62 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2711, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 64 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                 foreach (var pt in Model.PokemonType)
                                {
                                    if (p.Id == pt.PokemonsId)
                                    {
                                        

#line default
#line hidden
#line 68 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                         foreach (var t in Model.PokeType)
                                        {
                                            if (pt.PokeTypeId == t.Id)
                                            {

#line default
#line hidden
            BeginContext(3159, 112, true);
            WriteLiteral("                                                <span style=\"margin-right: 5px;\"><img class=\"pokimg3 afbeelding\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3271, "\"", 3315, 2);
            WriteAttributeValue("", 3277, "/uploads/images/types/", 3277, 22, true);
#line 72 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3299, t.ImageFileName, 3299, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3316, "\"", 3329, 1);
#line 72 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3322, t.Name, 3322, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3330, "\"", 3345, 1);
#line 72 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3338, t.Name, 3338, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3346, 10, true);
            WriteLiteral("></span>\r\n");
            EndContext();
#line 73 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                            }
                                        }

#line default
#line hidden
#line 74 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                         
                                    }
                                }

#line default
#line hidden
            BeginContext(3520, 163, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <img class=\"pokimg2 afbeelding col-md-12\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3683, "\"", 3751, 2);
            WriteAttributeValue("", 3689, "https://assets.pokemon.com/assets/cms2/img/pokedex/full/", 3689, 56, true);
#line 80 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3745, p.url, 3745, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3752, "\"", 3765, 1);
#line 80 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3758, p.Name, 3758, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3766, "\"", 3781, 1);
#line 80 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 3774, p.Name, 3774, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3782, 148, true);
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 84 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var hp in Model.Pokemon)
                                    {
                                        if (hp.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(4144, 189, true);
            WriteLiteral("                                            <p>HP</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4333, "\"", 4366, 4);
            WriteAttributeValue("", 4341, "width:calc(", 4341, 11, true);
#line 90 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 4352, hp.HP, 4352, 6, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4358, "*", 4359, 2, true);
            WriteAttributeValue(" ", 4360, "10%);", 4361, 6, true);
            EndWriteAttribute();
            BeginContext(4367, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 93 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(4560, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 95 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var atk in Model.Pokemon)
                                    {
                                        if (atk.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(4776, 193, true);
            WriteLiteral("                                            <p>Attack</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4969, "\"", 5007, 4);
            WriteAttributeValue("", 4977, "width:calc(", 4977, 11, true);
#line 101 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 4988, atk.Attack, 4988, 11, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4999, "*", 5000, 2, true);
            WriteAttributeValue(" ", 5001, "10%);", 5002, 6, true);
            EndWriteAttribute();
            BeginContext(5008, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 104 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(5201, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 106 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var spatk in Model.Pokemon)
                                    {
                                        if (spatk.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(5421, 201, true);
            WriteLiteral("                                            <p>Special attack</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5622, "\"", 5670, 4);
            WriteAttributeValue("", 5630, "width:calc(", 5630, 11, true);
#line 112 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 5641, spatk.Special_Attack, 5641, 21, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5662, "*", 5663, 2, true);
            WriteAttributeValue(" ", 5664, "10%);", 5665, 6, true);
            EndWriteAttribute();
            BeginContext(5671, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 115 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(5864, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 117 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var def in Model.Pokemon)
                                    {
                                        if (def.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(6080, 194, true);
            WriteLiteral("                                            <p>Defense</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6274, "\"", 6313, 4);
            WriteAttributeValue("", 6282, "width:calc(", 6282, 11, true);
#line 123 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 6293, def.Defense, 6293, 12, false);

#line default
#line hidden
            WriteAttributeValue(" ", 6305, "*", 6306, 2, true);
            WriteAttributeValue(" ", 6307, "10%);", 6308, 6, true);
            EndWriteAttribute();
            BeginContext(6314, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 126 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(6507, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 128 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var spdef in Model.Pokemon)
                                    {
                                        if (spdef.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(6727, 202, true);
            WriteLiteral("                                            <p>Special defense</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6929, "\"", 6978, 4);
            WriteAttributeValue("", 6937, "width:calc(", 6937, 11, true);
#line 134 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 6948, spdef.Special_Defense, 6948, 22, false);

#line default
#line hidden
            WriteAttributeValue(" ", 6970, "*", 6971, 2, true);
            WriteAttributeValue(" ", 6972, "10%);", 6973, 6, true);
            EndWriteAttribute();
            BeginContext(6979, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 137 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(7172, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 139 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                     foreach (var sp in Model.Pokemon)
                                    {
                                        if (sp.Id == p.Id)
                                        {

#line default
#line hidden
            BeginContext(7386, 192, true);
            WriteLiteral("                                            <p>Speed</p>\r\n                                            <div class=\"skill-bar\">\r\n                                                <div class=\"fill\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 7578, "\"", 7614, 4);
            WriteAttributeValue("", 7586, "width:calc(", 7586, 11, true);
#line 145 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
WriteAttributeValue("", 7597, sp.Speed, 7597, 9, false);

#line default
#line hidden
            WriteAttributeValue(" ", 7606, "*", 7607, 2, true);
            WriteAttributeValue(" ", 7608, "10%);", 7609, 6, true);
            EndWriteAttribute();
            BeginContext(7615, 111, true);
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 148 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(7808, 334, true);
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <div class=""row"">
                            <div class=""col-md-3""></div>
                            <div class=""col-md-3"">");
            EndContext();
            BeginContext(8142, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816308f4bb0393763a97601c5b44e5437d1b2d3529474", async() => {
                BeginContext(8218, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 157 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
                                                                                                           WriteLiteral(p.Id);

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
            BeginContext(8226, 58, true);
            WriteLiteral("</div>\r\n                            <div class=\"col-md-3\">");
            EndContext();
            BeginContext(8284, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816308f4bb0393763a97601c5b44e5437d1b2d3532052", async() => {
                BeginContext(8340, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8356, 150, true);
            WriteLiteral("</div>\r\n                            <div class=\"col-md-3\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 163 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(8532, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 166 "C:\Users\Zorro\Documents\Server\timwessels\public_html\pokemon\PokemonDB\Pokemon\Areas\Admin\Views\Pokemons\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokemonView> Html { get; private set; }
    }
}
#pragma warning restore 1591
