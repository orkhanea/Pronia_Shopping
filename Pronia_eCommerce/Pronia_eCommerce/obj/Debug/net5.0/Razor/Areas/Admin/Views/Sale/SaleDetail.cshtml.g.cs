#pragma checksum "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4536da3f0cf9dbdda276376b962241b677510699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sale_SaleDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Sale/SaleDetail.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4536da3f0cf9dbdda276376b962241b677510699", @"/Areas/Admin/Views/Sale/SaleDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4455d5c7c7d4b08a97864a7e5c95dada621291", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sale_SaleDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height: 100%; border-radius: 50%; box-shadow: 0 0 20px 0px #001a32; object-fit: cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light m-3 px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important; height: 100% !important; object-position: center center; object-fit: contain !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row justify-content-center\">\r\n\r\n    <div class=\"col-lg-8\">\r\n        <div class=\"card text-center\">\r\n            <div class=\"card-header p-2\" style=\" font-size: 20px;\">\r\n                Customer Information <span");
            BeginWriteAttribute("class", " class=\"", 240, "\"", 299, 1);
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
WriteAttributeValue("", 248, Model.EndUserId!=null?"text-info":"text-warning", 248, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 13px !important; vertical-align: text-top !important;\"> ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                                                                                                                                                             Write(Model.EndUserId!=null?" User":" Non-User");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""card-body p-2"" style="" display: flex;"">
                <div class=""col-lg-3"">
                    <div style="" width: 150px; height: 150px; margin-left: auto; margin-right: auto;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4536da3f0cf9dbdda276376b962241b6775106998482", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 799, "~/img/user/", 799, 11, true);
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
AddHtmlAttributeValue("", 810, Model.EndUserId!=null?(Model.EndUser.Image!=null?Model.EndUser.Image:"Avatar.png"):"Avatar.png", 810, 98, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-9 text-left\">\r\n                    <div class=\"card-title\" style=\"font-size: 20px; font-weight: 500; color: white;\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                    Write(Model.EndUserId!=null?Model.EndUser.Name + " " + Model.EndUser.Surname : Model.UnregisteredCustomer.FirstName + " " + Model.UnregisteredCustomer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"mr-2\" style=\"font-weight: bold; color: white;\">Country: </span>\r\n                        <span class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                            Write(Model.EndUserId!=null?Model.EndUser.Country.CountryName:Model.UnregisteredCustomer.CountyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"mr-2\" style=\"font-weight: bold; color: white;\">Email: </span>\r\n                        <span class=\"cart-text\">");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                            Write(Model.EndUserId!=null?Model.EndUser.Email:Model.UnregisteredCustomer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"mr-2\" style=\"font-weight: bold; color: white;\">Phone: </span>\r\n                        <span class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                            Write(Model.EndUserId!=null?Model.EndUser.PhoneNumber:Model.UnregisteredCustomer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
            </div>
            <div class=""card-footer p-2"">
                <div>
                    <p class=""m-0"" style="" font-weight: 600; font-size: 18px; color: #ffffff;"">Address</p>
                    <p>");
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                   Write(Model.EndUserId!=null?Model.EndUser.BillingAddress:Model.UnregisteredCustomer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4536da3f0cf9dbdda276376b962241b67751069913463", async() => {
                WriteLiteral("Back To Sale");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title text-center m-4\" style=\"font-size: 30px !important;\">Sale Details</h4>\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                  
                    if (TempData["SaleError2"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important; padding: 15px !important;\" class=\"alert text-center text-warning\">");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                                                                                                           Write(TempData["SaleError2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"

                        TempData["SaleError2"] = null;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive text-center"">
                    <table class=""table table-bordered table-hover"">
                        <thead>
                            <tr class=""make-it-unvisible"">
                                <th class=""tableTrCustom"">
                                    #
                                </th>
                                <th class=""tableTrCustom"">
                                    Product Image
                                </th>
                                <th class=""tableTrCustom"">
                                    Product Name
                                </th>
                                <th class=""tableTrCustom"">
                                    Size
                                </th>
                                <th class=""tableTrCustom"">
                                    SKU
                                </th>
                                <th class=""tableTrCustom"">
                       ");
            WriteLiteral(@"             Order Date
                                </th>
                                <th class=""tableTrCustom"">
                                    Quantity
                                </th>
                                <th class=""tableTrCustom"">
                                    Price
                                </th>
                                <th class=""tableTrCustom"">
                                    Total
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                              
                                int counter = 0;
                                foreach (var item in Model.SaleItems)
                                {
                                    counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td style=""width: 5% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            ");
#nullable restore
#line 101 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 25% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            <div style=""display: inline-block; width: 200px !important; height: 150px !important; "">
                                                <div class=""owl-carousel-admin owl-theme owl-loaded"" style=""width: 100% !important; height: 100% !important; overflow: hidden !important; display: inline-block !important; "">
                                                    <div class=""owl-stage-outer w-100 h-100"">
                                                        <div class=""owl-stage d-flex h-100"">

");
#nullable restore
#line 109 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                                             foreach (var imgs in item.ProductSizeToProduct.Product.ProductImages)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"owl-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4536da3f0cf9dbdda276376b962241b67751069920639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6768, "~/img/products/", 6768, 15, true);
#nullable restore
#line 111 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
AddHtmlAttributeValue("", 6783, imgs.Image, 6783, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 112 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                        <td style=""width: 30% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important;"">
                                            ");
#nullable restore
#line 120 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(item.ProductSizeToProduct.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 30% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important;"">
                                            ");
#nullable restore
#line 123 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(item.ProductSizeToProduct.ProductSize.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 15% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            ");
#nullable restore
#line 126 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(item.ProductSizeToProduct.Product.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 15% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            ");
#nullable restore
#line 129 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(Model.SaleDate.ToString("d MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 15% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            ");
#nullable restore
#line 132 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 10% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            $");
#nullable restore
#line 135 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td style=""width: 10% !important; padding-right: 10px !important; padding-left: 10px !important; vertical-align: middle !important; font-weight: 500 !important; "">
                                            $");
#nullable restore
#line 138 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                         Write(item.Price*item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 141 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\SaleDetail.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
