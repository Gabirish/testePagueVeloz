#pragma checksum "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5fcb5107e2c74dffdeb0cd89f5a3a44d4fb7fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores_Listar), @"mvc.1.0.view", @"/Views/Fornecedores/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/Listar.cshtml", typeof(AspNetCore.Views_Fornecedores_Listar))]
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
#line 1 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\_ViewImports.cshtml"
using TestePagueVeloz;

#line default
#line hidden
#line 2 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\_ViewImports.cshtml"
using TestePagueVeloz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba5fcb5107e2c74dffdeb0cd89f5a3a44d4fb7fb", @"/Views/Fornecedores/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd4922e17634b7995d042988d5108f3ef4cb828", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestePagueVeloz.Models.Fornecedor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryUi/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryUi/jquery-ui.theme.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryUi/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Deletar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(92, 257, true);
            WriteLiteral(@"
<h2>Fornecedores</h2>



<table class=""table table-striped"">
    <thead>
        <tr>
            <th>CPF  / CNPJ</th>
            <th>Fornecedor</th>
            <th>Empresa</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
         foreach (var fornecedor in Model)
        {

#line default
#line hidden
            BeginContext(404, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(443, 20, false);
#line 24 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
               Write(fornecedor.CnpjOuCpf);

#line default
#line hidden
            EndContext();
            BeginContext(463, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(491, 15, false);
#line 25 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
               Write(fornecedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(506, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(535, 65, false);
#line 26 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
                Write(fornecedor.Empresa != null ? fornecedor.Empresa.NomeFantasia : "");

#line default
#line hidden
            EndContext();
            BeginContext(601, 50, true);
            WriteLiteral(" </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(652, 135, false);
#line 28 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
               Write(Html.ActionLink("Editar", "Editar", "Fornecedores", new { fornecedorId = fornecedor.FornecedorId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(787, 52, true);
            WriteLiteral("\r\n                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 839, "\"", 921, 3);
            WriteAttributeValue("", 849, "deletar(\'/Fornecedores/Deletar?fornecedorId=\'+", 849, 46, true);
#line 29 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
WriteAttributeValue(" ", 895, fornecedor.FornecedorId, 896, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 920, ")", 920, 1, true);
            EndWriteAttribute();
            BeginContext(922, 55, true);
            WriteLiteral(">X</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(988, 75, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"width:100%; text-align:right;\">\r\n    ");
            EndContext();
            BeginContext(1064, 115, false);
#line 37 "C:\Users\Vini_\source\repos\TestePagueVeloz\TestePagueVeloz\Views\Fornecedores\Listar.cshtml"
Write(Html.ActionLink("Cadastrar Fornecedor", "NovoFornecedor", "Fornecedores", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 289, true);
            WriteLiteral(@"
</div>

<div style=""display:none"">
    <div id=""dialog-confirm"" title=""Deletar Fornecedor?"">
        <p><span class=""ui-icon ui-icon-alert"" style=""float:left; margin:12px 12px 20px 0;""></span>O fornecedor será deletado permanentemente. Você tem certeza?</p>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1486, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1492, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc0462f8949e4fe2822423e8b4585f29", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1557, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1563, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6087d51b1f444531b669b5ad0a812b3d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1634, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1640, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd68265acb214963969131aafe1412de", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1718, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1724, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b264ab306a4a4377ba6e9d413c467a05", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1786, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1791, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestePagueVeloz.Models.Fornecedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
