#pragma checksum "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af6c07b6f7db561791cf0756583a9b6d2b81b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af6c07b6f7db561791cf0756583a9b6d2b81b52", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3fe617c7a990291cc5191a30ff3477ba347ac8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/products/product-3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Wishlist Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/products/product-4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/products/product-5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!-- #region Wishlist -->\r\n<div class=\"wishlist-full pt-100 pb-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af6c07b6f7db561791cf0756583a9b6d2b81b525678", async() => {
                WriteLiteral(@"
                    <div class=""table-content table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""product-remove"">remove</th>
                                    <th class=""product-thumbnail"">images</th>
                                    <th class=""cart-product-name"">Product</th>
                                    <th class=""product-price"">Unit Price</th>
                                    <th class=""product-stock-status"">Quantity</th>
                                    <th class=""cart-btn"">Total</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""product-remove"">
                                        <a href=""#"">
                                            <i class=""fal fa-times"" data-tippy=""Remove"" data-tip");
                WriteLiteral(@"py-inertia=""true""
                                               data-tippy-animation=""shift-away"" data-tippy-delay=""50""
                                               data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""></i>
                                        </a>
                                    </td>
                                    <td class=""product-thumbnail"">
                                        <a href=""#"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0af6c07b6f7db561791cf0756583a9b6d2b81b527517", async() => {
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
                WriteLiteral(@"
                                        </a>
                                    </td>
                                    <td class=""product-name""><a href=""#"">American Marigold</a></td>
                                    <td class=""product-price""><span class=""amount"">$23.45</span></td>
                                    <td class=""quantity"">
                                        <div class=""cart-action"" style=""display: inline;"">
                                            <input class=""cart-action-box"" value=""1"" type=""text"">
                                            <div class=""minus quantity-btn"">
                                                <i class=""fa fa-minus""></i>
                                            </div>
                                            <div class=""plus quantity-btn"">
                                                <i class=""fa fa-plus""></i>
                                            </div>
                                        </div>
                   ");
                WriteLiteral(@"                 </td>
                                    <td class=""product-subtotal""><span class=""amount"">$23.45</span></td>
                                </tr>
                                <tr>
                                    <td class=""product-remove"">
                                        <a href=""#"">
                                            <i class=""fal fa-times"" data-tippy=""Remove"" data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away"" data-tippy-delay=""50""
                                               data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""></i>
                                        </a>
                                    </td>
                                    <td class=""product-thumbnail"">
                                        <a href=""#"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0af6c07b6f7db561791cf0756583a9b6d2b81b5210710", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </a>
                                    </td>
                                    <td class=""product-name""><a href=""#"">Black Eyed Susan</a></td>
                                    <td class=""product-price""><span class=""amount"">$25.45</span></td>
                                    <td class=""quantity"">
                                        <div class=""cart-action"" style=""display: inline;"">
                                            <input class=""cart-action-box"" value=""1"" type=""text"">
                                            <div class=""minus quantity-btn"">
                                                <i class=""fa fa-minus""></i>
                                            </div>
                                            <div class=""plus quantity-btn"">
                                                <i class=""fa fa-plus""></i>
                                            </div>
                                        </div>
                    ");
                WriteLiteral(@"                </td>
                                    <td class=""product-subtotal""><span class=""amount"">$23.45</span></td>
                                </tr>
                                <tr>
                                    <td class=""product-remove"">
                                        <a href=""#"">
                                            <i class=""fal fa-times"" data-tippy=""Remove"" data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away"" data-tippy-delay=""50""
                                               data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""></i>
                                        </a>
                                    </td>
                                    <td class=""product-thumbnail"">
                                        <a href=""#"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0af6c07b6f7db561791cf0756583a9b6d2b81b5213903", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </a>
                                    </td>
                                    <td class=""product-name""><a href=""#"">Bleeding Heart</a></td>
                                    <td class=""product-price""><span class=""amount"">$30.45</span></td>
                                    <td class=""quantity"">
                                        <div class=""cart-action"" style=""display: inline;"">
                                            <input class=""cart-action-box"" value=""1"" type=""text"">
                                            <div class=""minus quantity-btn"">
                                                <i class=""fa fa-minus""></i>
                                            </div>
                                            <div class=""plus quantity-btn"">
                                                <i class=""fa fa-plus""></i>
                                            </div>
                                        </div>
                      ");
                WriteLiteral(@"              </td>
                                    <td class=""product-subtotal""><span class=""amount"">$23.45</span></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""row justify-content-end"">
                        <div class=""col-md-5 ml-auto"">
                            <div class=""cart-page-total"">
                                <h2>Cart totals</h2>
                                <ul>
                                    <li>Subtotal <span>$79.35</span></li>
                                    <li>Total <span>$79.35</span></li>
                                </ul>
                                <a href=""#"">Proceed to checkout</a>
                            </div>
                        </div>
                    </div>
                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- #endregion Wishlist End -->");
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
