#pragma checksum "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad54ad9c10006127f4c943300dc3648cd3a2bb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Potrosac_TrenutnaPorudzbina), @"mvc.1.0.view", @"/Views/Potrosac/TrenutnaPorudzbina.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad54ad9c10006127f4c943300dc3648cd3a2bb4", @"/Views/Potrosac/TrenutnaPorudzbina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Potrosac_TrenutnaPorudzbina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Potrosac/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad54ad9c10006127f4c943300dc3648cd3a2bb43850", async() => {
                WriteLiteral(@"
    <style>
        

        .mojp {
            text-align: center;
            font-size: 60px;
            margin-top: 0px;
            color: black;
        }
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad54ad9c10006127f4c943300dc3648cd3a2bb45305", async() => {
                WriteLiteral("\r\n    <center>\r\n        <div class=\"mojdiv\">\r\n            <table border=\"1\">\r\n                <tr>\r\n                    <th>Proizvodi</th>\r\n                    <td>\r\n");
#nullable restore
#line 37 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                         foreach (var item in Model.Proizvod)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>");
#nullable restore
#line 39 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                          Write(item.Proizvod.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 39 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                                               Write(item.Kolicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Adresa</th>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                   Write(Model.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Komnetar</th>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                   Write(Model.Komentar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Cena</th>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                   Write(Model.Cena);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n\r\n        <h3>Dostava stize za:</h3>\r\n        <p class=\"mojp\" id=\"tajmer\"></p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad54ad9c10006127f4c943300dc3648cd3a2bb48336", async() => {
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
                WriteLiteral("\r\n    </center>\r\n\r\n    <script>\r\n        let time = ");
#nullable restore
#line 64 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
              Write(ViewBag.Minuti.Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *60 + ");
#nullable restore
#line 64 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Potrosac\TrenutnaPorudzbina.cshtml"
                                            Write(ViewBag.Minuti.Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" %60;

        const countdownEl = document.getElementById('tajmer');

        setInterval(updateCountdown, 1000);

        function updateCountdown() {
            const minutes = Math.floor(time / 60);
            let seconds = time % 60;

            seconds = seconds < 10 ? '0' + seconds : seconds;

            countdownEl.innerHTML = minutes + "":"" + seconds;
            time--;

            if (minutes == 0 && seconds == 0) {
                window.location.href = ""/Potrosac/Dashboard"";
            }
        }
    </script>
    
");
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
