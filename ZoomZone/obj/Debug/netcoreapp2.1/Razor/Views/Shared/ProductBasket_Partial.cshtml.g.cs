#pragma checksum "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e83396632261caa1913a8c5167da30f5f7cf615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductBasket_Partial), @"mvc.1.0.view", @"/Views/Shared/ProductBasket_Partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductBasket_Partial.cshtml", typeof(AspNetCore.Views_Shared_ProductBasket_Partial))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 4 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\_ViewImports.cshtml"
using ZoomZone.Models;

#line default
#line hidden
#line 2 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\_ViewImports.cshtml"
using ZoomZone.Controllers;

#line default
#line hidden
#line 3 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\_ViewImports.cshtml"
using ZoomZone.ViewModel;

#line default
#line hidden
#line 5 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e83396632261caa1913a8c5167da30f5f7cf615", @"/Views/Shared/ProductBasket_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac73ce083d6cecb4c95ac79201b4733059061dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductBasket_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(58, 61, true);
            WriteLiteral("    <div class=\"cart_item\">\r\n        <div class=\"cart_img\">\r\n");
            EndContext();
#line 7 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
             if (item.Image != null)
            {

#line default
#line hidden
            BeginContext(172, 28, true);
            WriteLiteral("                <a href=\"#\">");
            EndContext();
            BeginContext(200, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4598b97deef4030b01e0e43e99a909e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 231, "~/img/MyProduct/", 231, 16, true);
#line 9 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
AddHtmlAttributeValue("", 247, item.Image, 247, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(267, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 10 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"

            }

#line default
#line hidden
            BeginContext(290, 73, true);
            WriteLiteral("        </div>\r\n        <div class=\"cart_info\">\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(364, 9, false);
#line 14 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(373, 50, true);
            WriteLiteral("</a>\r\n\r\n            <span class=\"quantity\">Count: ");
            EndContext();
            BeginContext(424, 10, false);
#line 16 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                                     Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(434, 95, true);
            WriteLiteral("</span>\r\n            <div>\r\n                <span class=\"new_price\" style=\"font-size: 17px;\">\r\n");
            EndContext();
#line 19 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                     if (item.Discount != 0)
                    {
                        

#line default
#line hidden
            BeginContext(624, 62, false);
#line 21 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                    Write((item.Price - (item.Price * item.Discount) / 100) * item.Count);

#line default
#line hidden
            EndContext();
#line 21 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                                                                                         
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(787, 25, false);
#line 25 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                    Write((item.Price) * item.Count);

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                                                    
                    }

#line default
#line hidden
            BeginContext(838, 104, true);
            WriteLiteral("                </span>\r\n                <span class=\"old_price\" style=\"color:red;  font-size: 15px;\">\r\n");
            EndContext();
#line 29 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                     if (item.Discount != null && item.Discount != 0)
                    {

#line default
#line hidden
            BeginContext(1036, 51, true);
            WriteLiteral("                    <del>\r\n                        ");
            EndContext();
            BeginContext(1089, 25, false);
#line 32 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                    Write((item.Price) * item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 30, true);
            WriteLiteral("\r\n                    </del>\r\n");
            EndContext();
#line 34 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1168, 203, true);
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n          \r\n\r\n        </div>\r\n        <div class=\"cart_remove\">\r\n            <a href=\"#\"><i class=\"ion-android-close\"></i></a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 45 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Shared\ProductBasket_Partial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
