#pragma checksum "C:\Users\lucas\OneDrive\Área de Trabalho\Visual Studio\RsMotores.WEB\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d4a373f0c3b0b5fa636ad2540d77245cd04d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\Users\lucas\OneDrive\Área de Trabalho\Visual Studio\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\OneDrive\Área de Trabalho\Visual Studio\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d4a373f0c3b0b5fa636ad2540d77245cd04d1e", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e173621eea024fc620804c64a2adbbeebca619", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lucas\OneDrive\Área de Trabalho\Visual Studio\RsMotores.WEB\Views\Product\Create.cshtml"
  
    ViewBag.Title = "Cadastro do Produto";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<html lang=""en"">


<style>
    body {
        background-color: #FFC0A1;
    }

    input {
        background-color: #eee;
        border: none;
        padding: 8px 10px;
    }

    footer {
        background-color: white;
    }

    .main-content {
        display: flex;
        flex-direction: column;
        align-items: center;
        width: 100%;
    }

    .child-content {
        width: 50%;
    }

    .btn-field {
        display: flex;
        justify-content: center;
    }

    .btn-style {
        border: 1px solid purple;
        border-radius: 4px;
        width: 140px;
        background-color: white;
        color: purple;
        font-weight: 500;
        margin-bottom: 40px;
    }

        .btn-style:hover {
            background-color: purple;
            color: white;
        }

    .form-size {
        background-color: white;
        border: 1px solid #FFC0A1;
        border-radius: 10px;
        box-shadow: 0 14");
            WriteLiteral(@"px 28px rgb(0 0 0 / 25%), 0 10px 10px rgb(0 0 0 / 22%);
    }

    .form-style {
        width: 75%;
    }

    .register-user {
        font-size: 25px;
        text-align: center;
        margin: 20px 0px;
        padding-top: 40px;
    }

    a {
        text-align: center;
        text-decoration: none;
        color: purple !important;
        padding: 7px 70px 7px 70px;
    }

        a:hover {
            text-align: center;
            text-decoration: none;
            color: white !important;
        }

    .msg {
        color: green;
        font-weight: bold;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93d4a373f0c3b0b5fa636ad2540d77245cd04d1e6641", async() => {
                WriteLiteral("\r\n    <div class=\"main-content\">\r\n        <div class=\"child-content\">\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93d4a373f0c3b0b5fa636ad2540d77245cd04d1e6992", async() => {
                    WriteLiteral(@"
                <h1 class=""register-user"">Cadastro de Produto</h1>
                <div style=""margin-bottom: 10px;"" class=""d-flex justify-content-center""><input type=""text"" id=""nameProduct"" name=""nameProduct"" class=""form-style"" placeholder=""Nome do produto"" required /></div>
                <div style=""margin-bottom: 10px;"" class=""d-flex justify-content-center""><input type=""number"" step=""0.01"" id=""price"" name=""price"" class=""form-style"" placeholder=""Preço"" required /></div>
                <div style=""margin-bottom: 10px;"" class=""d-flex justify-content-center""><input type=""number"" step=""1"" min=""1"" id=""quantity"" name=""quantity"" class=""form-style"" placeholder=""Quantidade"" required /></div>
                <div class=""btn-field"">
                    <div><input type=""submit"" value=""Cadastrar"" class=""btn-style"" /></div>
                    <div class=""btn-style d-flex align-items-center justify-content-center"" style=""margin-left: 6px;""><a href=""/Product/Show/"">Listar</a></div>
                </div>
   ");
                    WriteLiteral("             <div class=\"d-flex justify-content-center\" style=\"margin-bottom: 10px;\"><span class=\"msg\">");
#nullable restore
#line 107 "C:\Users\lucas\OneDrive\Área de Trabalho\Visual Studio\RsMotores.WEB\Views\Product\Create.cshtml"
                                                                                                     Write(Model);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span></div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
