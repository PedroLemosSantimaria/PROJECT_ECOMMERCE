#pragma checksum "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b08f428470c7dfed3da2d22bdca8a0687243177c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Skate), @"mvc.1.0.view", @"/Views/Produtos/Skate.cshtml")]
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
#line 1 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\_ViewImports.cshtml"
using GSA_PROJETO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\_ViewImports.cshtml"
using GSA_PROJETO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08f428470c7dfed3da2d22bdca8a0687243177c", @"/Views/Produtos/Skate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bfcc42f11fd30340343b843fc5a660c11bfe38a", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Skate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Models.Produtos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "roupas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>Skate - ALLSKATERS</title>\r\n<br />\r\n<br />\r\n<div class=\"container-full\">\r\n    <div class=\"container-barra-filtro\">\r\n        <select");
            BeginWriteAttribute("name", " name=\"", 176, "\"", 183, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 184, "\"", 189, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c3828", async() => {
                WriteLiteral(" Pesquisar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c5003", async() => {
                WriteLiteral("Pre??o: maior ao menor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c6189", async() => {
                WriteLiteral("Pre??o:menor ao maior");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c7374", async() => {
                WriteLiteral("A - Z");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c8544", async() => {
                WriteLiteral("Z - A");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c9714", async() => {
                WriteLiteral("Mais antigo ao mais novo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08f428470c7dfed3da2d22bdca8a0687243177c10903", async() => {
                WriteLiteral("Mais novo ao mais antigos ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </select>\r\n    </div>\r\n    <button class=\"button-filtro-one\">Buscar</button>\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n    <div class=\"container\">\r\n    \r\n\r\n        <div class=\"container-store-one\">\r\n");
#nullable restore
#line 29 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
             foreach (Projeto.Models.Produtos p in Model)
                    {
                        string formato = "data:image/jpeg;base64," + Convert.ToBase64String(p.BytesArquivo);


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"skate\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1101, "\"", 1115, 1);
#nullable restore
#line 34 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
WriteAttributeValue("", 1107, formato, 1107, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 1116, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:210px; height:210px\" >\r\n                    <h3 class=\"titulo-skate\">");
#nullable restore
#line 36 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
                                        Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"descri????o-skate\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
                   Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <button class=\"button-buy\">");
#nullable restore
#line 40 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
                                          Write(p.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comprar</button>\r\n                    <br> <br>\r\n                    <hr size=\"2\" width=\"80%\">\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\aluno\Documents\Pedro Lemos\GSA-PROJETO\GSA-PROJETO\Views\Produtos\Skate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <hr width=\"80%\">\r\n            </div>\r\n\r\n\r\n\r\n\r\n        <div class=\"container-store-options\">\r\n\r\n            <p class=\"margin-options\">Cor</p>\r\n            <br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 1769, "\"", 1775, 0);
            EndWriteAttribute();
            WriteLiteral(">Preto</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 1925, "\"", 1931, 0);
            EndWriteAttribute();
            WriteLiteral(">Vermelho</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2084, "\"", 2090, 0);
            EndWriteAttribute();
            WriteLiteral(">Laranja</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2242, "\"", 2248, 0);
            EndWriteAttribute();
            WriteLiteral(">Amarelo</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\"><br><br>\r\n            <hr size=\"2\">\r\n            <p class=\"margin-options\">Tamanho</p>\r\n            <br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2482, "\"", 2488, 0);
            EndWriteAttribute();
            WriteLiteral(">140mm</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2638, "\"", 2644, 0);
            EndWriteAttribute();
            WriteLiteral(">139mm</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2794, "\"", 2800, 0);
            EndWriteAttribute();
            WriteLiteral(">138mm</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\">\r\n            <br><br>\r\n            <label class=\"margin-options\"");
            BeginWriteAttribute("for", " for=\"", 2950, "\"", 2956, 0);
            EndWriteAttribute();
            WriteLiteral(">142mm</label>\r\n            <input class=\"margin-options\" type=\"checkbox\" name=\"sd\"><br><br>\r\n            <hr size=\"2\">\r\n            <br><br>\r\n\r\n\r\n\r\n            <a class=\"margin-options\"");
            BeginWriteAttribute("href", " href=\"", 3143, "\"", 3150, 0);
            EndWriteAttribute();
            WriteLiteral(">Shape </a><br><br>\r\n            <a class=\"margin-options\"");
            BeginWriteAttribute("href", " href=\"", 3209, "\"", 3216, 0);
            EndWriteAttribute();
            WriteLiteral(">Shape Maple</a><br><br>\r\n            <a class=\"margin-options\"");
            BeginWriteAttribute("href", " href=\"", 3280, "\"", 3287, 0);
            EndWriteAttribute();
            WriteLiteral(">Shape Nacional</a><br><br>\r\n            <a class=\"margin-options\"");
            BeginWriteAttribute("href", " href=\"", 3354, "\"", 3361, 0);
            EndWriteAttribute();
            WriteLiteral(">Skate montado</a><br><br>\r\n\r\n            <button class=\"search\">Buscar</button>\r\n\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Models.Produtos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
