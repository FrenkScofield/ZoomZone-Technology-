#pragma checksum "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df55a5687d0c281e9e6399da067eb72b5b70868a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Checkout.cshtml", typeof(AspNetCore.Views_Cart_Checkout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df55a5687d0c281e9e6399da067eb72b5b70868a", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac73ce083d6cecb4c95ac79201b4733059061dde", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinalStage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 592, true);
            WriteLiteral(@"

<!--breadcrumbs area start-->
<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""index.html"">home</a></li>
                        <li>Shopping Cart</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--breadcrumbs area end-->
<!--shopping cart area start -->
<div class=""shopping_cart_area mt-60"">
    <div class=""container"">
        ");
            EndContext();
            BeginContext(708, 6593, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b400037429c4eb4a55f53d339d6468d", async() => {
                BeginContext(725, 71, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n");
                EndContext();
#line 31 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                     if (Model.Count == 0)
                    {

#line default
#line hidden
                BeginContext(863, 295, true);
                WriteLiteral(@"                        <div class=""alert alert-warning"">
                            Deer user, you have not added anything to your God damn cart. Go and get something.
                            <br />
                            <a href=""/"">Go there!</a>
                        </div>
");
                EndContext();
#line 38 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                    }
                    else
                    {



#line default
#line hidden
                BeginContext(1234, 916, true);
                WriteLiteral(@"                    <div class=""table_desc"">
                        <div class=""cart_page table-responsive"">
                            <table>
                                <thead>
                                    <tr>
                                        <th class=""product_remove"">Delete</th>
                                        <th class=""product_thumb"">Image</th>
                                        <th class=""product_name"">Catagory</th>
                                        <th class=""product-price"">Name</th>
                                        <th class=""product_quantity"">Count</th>
                                        <th class=""product_total"">Price</th>
                                        <th class=""product_total"">Total Price</th>
                                    </tr>
                                </thead>
                                <tbody>
");
                EndContext();
#line 58 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                     foreach (var item in Model)
                                    {


#line default
#line hidden
                BeginContext(2257, 109, true);
                WriteLiteral("                                    <tr>\r\n                                        <td class=\"product_remove\">");
                EndContext();
                BeginContext(2366, 114, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed5ed7f5eac4b5ba434c3ff7bd0b671", async() => {
                    BeginContext(2447, 29, true);
                    WriteLiteral("<i class=\"fa fa-trash-o\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 62 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                                                                       WriteLiteral(item.ProductId);

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
                BeginContext(2480, 85, true);
                WriteLiteral("</td>\r\n                                        <td class=\"product_thumb\"><a href=\"#\">");
                EndContext();
                BeginContext(2565, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dacf0f4eab4d4e318033bafd9af99cbd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2575, "~/img/MyProduct/", 2575, 16, true);
#line 63 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
AddHtmlAttributeValue("", 2591, item.Image, 2591, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2611, 88, true);
                WriteLiteral("</a></td>\r\n                                        <td class=\"product_name\"><a href=\"#\">");
                EndContext();
                BeginContext(2700, 14, false);
#line 64 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                        Write(item.BrandName);

#line default
#line hidden
                EndContext();
                BeginContext(2714, 77, true);
                WriteLiteral("</a></td>\r\n                                        <td class=\"product-price\">");
                EndContext();
                BeginContext(2792, 9, false);
#line 65 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2801, 116, true);
                WriteLiteral("</td>\r\n                                        <td class=\"product_quantity\"><label></label> <input min=\"1\" max=\"100\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2917, "\"", 2936, 1);
#line 66 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2925, item.Count, 2925, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2937, 197, true);
                WriteLiteral(" type=\"number\"></td>\r\n                                        <td class=\"product-price\">\r\n                                            <span class=\"old_price\" style=\"color:red;  font-size: 15px;\">\r\n");
                EndContext();
#line 69 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                 if (item.Discount != null && item.Discount != 0)
                                                {

#line default
#line hidden
                BeginContext(3284, 115, true);
                WriteLiteral("                                                    <del>\r\n                                                        ");
                EndContext();
                BeginContext(3401, 10, false);
#line 72 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3412, 123, true);
                WriteLiteral("\r\n                                                        Anz\r\n                                                    </del>\r\n");
                EndContext();
#line 75 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3586, 122, true);
                WriteLiteral("\r\n                                            </span>\r\n                                            <p class=\"new_price\">\r\n");
                EndContext();
#line 79 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                 if (item.Discount != null)
                                                {
                                                    

#line default
#line hidden
                BeginContext(3890, 47, false);
#line 81 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                Write(item.Price - (item.Price * item.Discount) / 100);

#line default
#line hidden
                EndContext();
#line 81 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                                                      
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
                BeginContext(4150, 10, false);
#line 85 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                Write(item.Price);

#line default
#line hidden
                EndContext();
#line 85 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                 
                                                }

#line default
#line hidden
                BeginContext(4214, 325, true);
                WriteLiteral(@"                                                Azn
                                            </p>
                                        </td>
                                        <td class=""product_total"">
                                            <span class=""old_price"" style=""color:red;  font-size: 15px;"">
");
                EndContext();
#line 92 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                 if (item.Discount != null && item.Discount != 0)
                                                {

#line default
#line hidden
                BeginContext(4689, 115, true);
                WriteLiteral("                                                    <del>\r\n                                                        ");
                EndContext();
                BeginContext(4806, 25, false);
#line 95 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                    Write((item.Price) * item.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4832, 123, true);
                WriteLiteral("\r\n                                                        Azn\r\n                                                    </del>\r\n");
                EndContext();
#line 98 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                }

#line default
#line hidden
                BeginContext(5006, 147, true);
                WriteLiteral("\r\n                                            </span>\r\n                                            <p class=\"new_price\" style=\"font-size: 17px;\">\r\n");
                EndContext();
#line 102 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                 if (item.Discount != null)
                                                {
                                                    

#line default
#line hidden
                BeginContext(5335, 62, false);
#line 104 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                Write((item.Price - (item.Price * item.Discount) / 100) * item.Count);

#line default
#line hidden
                EndContext();
#line 104 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                                                                     
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
                BeginContext(5610, 25, false);
#line 108 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                Write((item.Price) * item.Count);

#line default
#line hidden
                EndContext();
#line 108 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                                                                
                                                }

#line default
#line hidden
                BeginContext(5689, 199, true);
                WriteLiteral("                                                Azn\r\n                                            </p>\r\n\r\n                                        </td>\r\n\r\n\r\n                                    </tr>\r\n");
                EndContext();
#line 117 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                                    }

#line default
#line hidden
                BeginContext(5927, 297, true);
                WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                        <div class=""cart_submit"">
                            <button type=""submit"">update cart</button>
                        </div>
                    </div>
");
                EndContext();
#line 126 "C:\Users\kam_a\Desktop\ZoomZoneTecnology\ZoomZone\Views\Cart\Checkout.cshtml"
                    }

#line default
#line hidden
                BeginContext(6247, 744, true);
                WriteLiteral(@"                </div>
            </div>
            <!--coupon code area start-->
            <div class=""coupon_area"">
                <div class=""row"">
                   
                    <div class=""col-lg-12 col-md-12"">
                        <div class=""coupon_code right"">
                            <h3>Cart Totals</h3>
                            <div class=""coupon_inner"">
                              
                                <div class=""cart_subtotal"">
                                    <p>Total</p>
                                    <p class=""cart_amount""></p>
                                </div>
                                <div class=""checkout_btn"">
                                    ");
                EndContext();
                BeginContext(6991, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "770fa5f36c0c4305bb25c335e7c87bb0", async() => {
                    BeginContext(7040, 19, true);
                    WriteLiteral("Proceed to Checkout");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7063, 231, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--coupon code area end-->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7301, 54, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!--shopping cart area end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591