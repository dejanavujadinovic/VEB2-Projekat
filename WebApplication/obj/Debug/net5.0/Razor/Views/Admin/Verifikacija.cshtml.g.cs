#pragma checksum "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3afebe1ef139f5f394345636e34fa026466e555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Verifikacija), @"mvc.1.0.view", @"/Views/Admin/Verifikacija.cshtml")]
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
#nullable restore
#line 6 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3afebe1ef139f5f394345636e34fa026466e555", @"/Views/Admin/Verifikacija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Verifikacija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("OdobriDostavljaca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("OdbijDostavljaca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3afebe1ef139f5f394345636e34fa026466e5555015", async() => {
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
            position: absolute;
            left: 50%;
            top: 50%;
            transform: translate(-50%, -50%);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3afebe1ef139f5f394345636e34fa026466e5556516", async() => {
                WriteLiteral(@"
    <center>
        <div class=""mojdiv"">
            <table border=""1"">
                <thead>
                    <tr>
                        <th>Korisnicko ime</th>
                        <th>Email</th>
                        <th>Ime i prezime</th>
                        <th>Datum rodjenja</th>
                        <th>Adresa</th>
                        <th>Status</th>
                    </tr>
");
#nullable restore
#line 47 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                     foreach (Korisnik item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                         if (item.Verifikovan == StatusVerifikacije.PROCESIRA)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.KorisnickoIme);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.ImePrezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.DatumRodjenja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Verifikovan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3afebe1ef139f5f394345636e34fa026466e5559887", async() => {
                    WriteLiteral("\r\n                                        <input type=\"text\" name=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 1895, "\"", 1914, 1);
#nullable restore
#line 61 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
WriteAttributeValue("", 1903, item.Email, 1903, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden />\r\n                                        <input type=\"submit\" value=\"Odobri\" />\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3afebe1ef139f5f394345636e34fa026466e55512013", async() => {
                    WriteLiteral("\r\n                                        <input type=\"text\" name=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 2270, "\"", 2289, 1);
#nullable restore
#line 67 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
WriteAttributeValue("", 2278, item.Email, 2278, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden />\r\n                                        <input type=\"submit\" value=\"Odbij\" />\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </thead>
            </table>
            <br /><br /><br /><br /><br />
            <table border=""1"">
                <thead>
                    <tr>
                        <th>Korisnicko ime</th>
                        <th>Email</th>
                        <th>Ime i prezime</th>
                        <th>Datum rodjenja</th>
                        <th>Adresa</th>
                        <th>Status</th>
                    </tr>
");
#nullable restore
#line 87 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                     foreach (Korisnik item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                         if (item.Verifikovan != StatusVerifikacije.PROCESIRA)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 92 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.KorisnickoIme);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 93 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 94 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.ImePrezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 95 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.DatumRodjenja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 96 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 97 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                               Write(item.Verifikovan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\dejan\Desktop\IVgodina\VEB2\Projekat\WebApplication\WebApplication\Views\Admin\Verifikacija.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </thead>\r\n            </table>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3afebe1ef139f5f394345636e34fa026466e55518272", async() => {
                    WriteLiteral("Nazad");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
