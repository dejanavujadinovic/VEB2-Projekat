#pragma checksum "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf799eac4454c4e516b4c87a56017975f8abf944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dostavljac_MojePorudzbine), @"mvc.1.0.view", @"/Views/Dostavljac/MojePorudzbine.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf799eac4454c4e516b4c87a56017975f8abf944", @"/Views/Dostavljac/MojePorudzbine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Dostavljac_MojePorudzbine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dostavljac/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf799eac4454c4e516b4c87a56017975f8abf9443842", async() => {
                WriteLiteral(@"
    <style>
        .mojdiv {
            width: initial;
            height: initial;
            background-color: lightpink;
            display: inline-block;
            position: relative;
            border: 5px solid gold;
        }

        body {
            background-color: gray;
        }

        p {
            /*position: absolute;
            left: 50%;
            top: 50%;
            transform: translate(-50%, -50%);*/
        }

        a {
            color: black;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf799eac4454c4e516b4c87a56017975f8abf9445347", async() => {
                WriteLiteral(@"
    <center>
        <div class=""mojdiv"">
            <table border=""1"">
                <tr>
                    <th>Proizvod</th>
                    <th>Adresa</th>
                    <th>Komentar</th>
                    <th>Cena</th>
                </tr>
");
#nullable restore
#line 43 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n");
#nullable restore
#line 47 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                             foreach (var item1 in item.novaPorudzbina.Proizvod)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>");
#nullable restore
#line 49 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                              Write(item1.Proizvod.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 49 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                                                    Write(item1.Kolicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                       Write(item.novaPorudzbina.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                       Write(item.novaPorudzbina.Komentar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                       Write(item.novaPorudzbina.Cena);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Dostavljac\MojePorudzbine.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf799eac4454c4e516b4c87a56017975f8abf9448812", async() => {
                    WriteLiteral("Nazad");
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
                WriteLiteral("\r\n        </div>\r\n    </center>\r\n");
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
