#pragma checksum "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e"
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
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bee977b4ce076335f439b29a16c68bc0f12bf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Wishlist Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-full-checker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/uncategorized/empty-cart..png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 20px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" color: white !important; background: #abd373 !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- #region Wishlist -->\r\n<div class=\"wishlist-full pt-100 pb-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                  
                    if (Model.Products != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e8780", async() => {
                WriteLiteral(@"
                            <div class=""table-content table-responsive"" style=""overflow: unset !important;"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""product-remove"">remove</th>
                                            <th class=""product-thumbnail"">images</th>
                                            <th class=""cart-product-name"">Product</th>
                                            <th class=""product-price"">Unit Price</th>
                                            <th class=""product-price"">Size</th>
                                            <th class=""product-stock-status"">Quantity</th>
                                            <th class=""cart-btn"">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                          
                                            foreach (var item in Model.Products)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td class=\"cart-product-remove\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e10643", async() => {
                    WriteLiteral(@"
                                                            <i class=""fal fa-times"" data-tippy=""Remove"" data-tippy-inertia=""true""
                                                               data-tippy-animation=""shift-away"" data-tippy-delay=""50""
                                                               data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""></i>
                                                        ");
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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </td>
                                                    <td class=""product-thumbnail"">
                                                        <a href=""#"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e13918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2494, "~/img/products/", 2494, 15, true);
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2509, item.ProductImages.Where(p=>p.Image!=null).FirstOrDefault().Image, 2509, 66, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\">\r\n                                                        <span");
                BeginWriteAttribute("class", " class=\"", 2976, "\"", 3022, 2);
                WriteAttributeValue("", 2984, "amount", 2984, 6, true);
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2990, "cart-product-price"+item.Id, 2991, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 44 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                              
                                                                bool noPrice = false;
                                                                foreach (var price in item.ProductSizeToProducts)
                                                                {
                                                                    if (price.Price != 0)
                                                                    {
                                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                   Write(price.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                    
                                                                        noPrice = false;
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        noPrice = true;
                                                                    }
                                                                }

                                                                if (noPrice)
                                                                {
                                                                    string noPriceText = "Price will be Update soon";
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                               Write(noPriceText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                
                                                                }
                                                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        </span>
                                                    </td>
                                                    <td style=""width: 230px;"" id=""cart-size"">
                                                        <select class=""nice-select wide border-bottom-0 rounded-0 cart-nice-select"">
");
#nullable restore
#line 70 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                             foreach (var size in item.ProductSizeToProducts)
                                                            {
                                                                if (size.Quantity > 0)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e20765", async() => {
#nullable restore
#line 74 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                        Write(size.ProductSize.Size);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                       WriteLiteral(size.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                }
                                                                else if (size.Quantity == 0)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e23296", async() => {
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                                 Write(size.ProductSize.Size);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                                WriteLiteral(size.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                                }


                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        </select>\r\n");
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                          
                                                            foreach (var s in item.ProductSizeToProducts)
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <input class=\"cart-price\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6403, "\"", 6419, 1);
#nullable restore
#line 87 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6411, s.Price, 6411, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                <input class=\"cart-price-product-id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6539, "\"", 6555, 1);
#nullable restore
#line 88 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6547, item.Id, 6547, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    </td>
                                                    <td class=""quantity"">
                                                        <div class=""cart-action"" style=""display: inline;"">
                                                            <input");
                BeginWriteAttribute("class", " class=\"", 6991, "\"", 7043, 2);
                WriteAttributeValue("", 6999, "cart-action-box", 6999, 15, true);
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 7014, "cart-action-box"+item.Id, 7015, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" type=\"text\">\r\n                                                            <div");
                BeginWriteAttribute("class", " class=\"", 7133, "\"", 7178, 3);
                WriteAttributeValue("", 7141, "minus", 7141, 5, true);
                WriteAttributeValue(" ", 7146, "quantity-btn", 7147, 13, true);
#nullable restore
#line 95 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 7159, "minus"+item.Id, 7160, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                <i class=\"fa fa-minus\"></i>\r\n                                                            </div>\r\n                                                            <div");
                BeginWriteAttribute("class", " class=\"", 7407, "\"", 7450, 3);
                WriteAttributeValue("", 7415, "plus", 7415, 4, true);
                WriteAttributeValue(" ", 7419, "quantity-btn", 7420, 13, true);
#nullable restore
#line 98 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 7432, "plus"+item.Id, 7433, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                                <i class=""fa fa-plus""></i>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class=""product-subtotal cart-product-sub-total"">
                                                        <span");
                BeginWriteAttribute("class", " class=\"", 7904, "\"", 7953, 2);
                WriteAttributeValue("", 7912, "amount", 7912, 6, true);
#nullable restore
#line 104 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 7918, "cart-product-subtotal"+item.Id, 7919, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">$23.45</span>\r\n                                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8046, "\"", 8062, 1);
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 8054, item.Id, 8054, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input id=\"cartProductCount\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8315, "\"", 8344, 1);
#nullable restore
#line 109 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 8323, Model.Products.Count, 8323, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral(@"                                    </tbody>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e34910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p style=\"font-size: 14px !important; color: #7d7d7d !important; \">There is nothing in your cart. Let\'s add some items.</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "960e5b2facc4e1156f9b2a0a9d48bc6cf8ad374e36269", async() => {
                WriteLiteral("Go To Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 135 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Cart\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- #endregion Wishlist End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
