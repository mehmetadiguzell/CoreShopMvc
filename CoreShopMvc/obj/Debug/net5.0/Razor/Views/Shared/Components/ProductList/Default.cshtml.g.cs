#pragma checksum "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec73e879104ead46e18058c4c23b2ed78933b123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductList/Default.cshtml")]
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
#line 1 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\_ViewImports.cshtml"
using CoreShopMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\_ViewImports.cshtml"
using CoreShopMvc.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec73e879104ead46e18058c4c23b2ed78933b123", @"/Views/Shared/Components/ProductList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf64928b0f4cb897357402510dd215b528559d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-9\">\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
         if (Model.Count > 0)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                    <div class=\"card h-100\">\r\n                        <a href=\"#\"><img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 338, "\"", 358, 1);
#nullable restore
#line 13 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
WriteAttributeValue("", 344, product.Image, 344, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:250px\"");
            BeginWriteAttribute("alt", " alt=\"", 392, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        <div class=\"card-body\">\r\n                            <h4 class=\"card-title\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec73e879104ead46e18058c4c23b2ed78933b1235248", async() => {
#nullable restore
#line 16 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                       WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </h4>\r\n                            <h5>$");
#nullable restore
#line 18 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <small class=\"text-muted\">Puan:");
#nullable restore
#line 22 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
                                                      Write(product.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
             

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger text-center\">\r\n            ??r??n bulunamad??\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\MA\source\repos\CoreShopMvc\CoreShopMvc\Views\Shared\Components\ProductList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
