#pragma checksum "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b020dd0531b01d6c94401fe9f71da974424fb22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shop_ProductDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Shop/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b020dd0531b01d6c94401fe9f71da974424fb22", @"/Areas/Admin/Views/Shop/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bee977b4ce076335f439b29a16c68bc0f12bf0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shop_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important; height: 100% !important; object-position: center center; object-fit: contain !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-inertia", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-animation", new global::Microsoft.AspNetCore.Html.HtmlString("shift-away"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-delay", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-arrow", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-theme", new global::Microsoft.AspNetCore.Html.HtmlString("sharpborder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-center my-4\" style=\"flex-direction: column;\">\r\n");
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
              
                if (TempData["CommentError"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"font-size: 20px !important;\" class=\"alert alert-danger col-lg-10 text-center\">");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                       Write(TempData["CommentError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"

                    TempData["CommentError"] = null;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-10 m-5"">
                <div class=""card text-center"">
                    <div class=""card-header alert alert-light p-3"" style=""border-bottom: none!important;"">
                        <span style=""font-size: 24px !important;""");
            BeginWriteAttribute("class", " class=\"", 711, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"alert p-2 mx-3\">\r\n");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                              
                                if (Model.Ratings.Count>0)
                                {
                                    var rval2 = Model.Ratings;
                                    var fiveS = 0;
                                    var fourS = 0;
                                    var threeS = 0;
                                    var twoS = 0;
                                    var oneS = 0;
                                    for (var rs = 0; rs < rval2.Count; rs++)
                                    {


                                        for (var str = 0; str < rval2.Count; str++)
                                        {
                                            if (rval2[str].Star == 5)
                                            {
                                                fiveS++;
                                            }
                                            else if (rval2[str].Star == 4)
                                            {
                                                fourS++;
                                            }
                                            else if (rval2[str].Star == 3)
                                            {
                                                threeS++;
                                            }
                                            else if (rval2[str].Star == 2)
                                            {
                                                twoS++;
                                            }
                                            else if (rval2[str].Star == 1)
                                            {
                                                oneS++;
                                            }
                                        }

                                    }

                                    decimal sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
                                    decimal rSum = fiveS + fourS + threeS + twoS + oneS;
                                    var sumRsum = Math.Round((sum / rSum), 1, MidpointRounding.ToEven);

                                    if (sumRsum != 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                    Write(sumRsum.ToString("F1"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color: goldenrod !important;\"></i>\r\n");
#nullable restore
#line 64 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                    Write("0.0");

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                ;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color: goldenrod !important;\"></i>\r\n");
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                    </div>\r\n                    <span class=\"mb-3\" style=\"font-size: 20px;\">\r\n                        SKU:\r\n                        <span>\r\n                            ");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                       Write(Model.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </span>
                    <div style=""padding-right: 20px !important; padding-left: 20px !important; width: 100% !important; height: 350px !important;"">
                        <div style=""display: inline-block; width: 100% !important; height: 350px !important;"">
                            <div class=""owl-carousel-admin owl-theme owl-loaded"" style=""width: 100% !important; height: 100% !important; overflow: hidden !important; display: inline-block !important; "">
                                <div class=""owl-stage-outer w-100 h-100"">
                                    <div class=""owl-stage d-flex h-100"">
");
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                         foreach (var img in Model.ProductImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"owl-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b020dd0531b01d6c94401fe9f71da974424fb2216775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4824, "~/img/products/", 4824, 15, true);
#nullable restore
#line 86 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
AddHtmlAttributeValue("", 4839, img.Image, 4839, 10, false);

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
            WriteLiteral("</div>\r\n");
#nullable restore
#line 87 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""mb-4 mt-4"" style="" display: flex; justify-content: center;"">
                            <table class=""bg-dark-light1 w-75 table table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>Size</th>
                                        <th>Quantity</th>
                                        <th>Prize</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                     foreach (var ps in Model.ProductSizeToProducts)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 109 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                           Write(ps.ProductSize.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 110 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                            Write(ps.Quantity>0?ps.Quantity:"Out Stock");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>$ ");
#nullable restore
#line 111 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                             Write(ps.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 113 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                        <div style=""display: flex; flex-direction: column; margin-left: auto; margin-right: auto;"" class=""w-75 py-4 text-left"">
                            <span class=""alert p-2 m-1""> <span style=""font-weight: bold !important; font-size: 16px !important; margin-right: 10px !important;"">Added Date: </span> ");
#nullable restore
#line 119 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                                                                                               Write(Model.CreatedDate.ToString("d MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"alert p-2 m-1\"> <span style=\"font-weight: bold !important; font-size: 16px !important; margin-right: 10px !important;\">Product Category: </span>  ");
#nullable restore
#line 120 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                                                                                                      Write(Model.ProductCat.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"alert p-2 m-1\">\r\n                                <span style=\"font-weight: bold !important; font-size: 16px !important; margin-right: 10px !important;\">Product Tags:</span>\r\n");
#nullable restore
#line 123 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                 foreach (var tag in Model.ProductTagToProducts)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 125 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                     Write(tag.ProductTag.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 126 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </span>
                        </div>
                    </div>
                </div>
            </div>


            <!-- Nav tabs -->
            <ul class=""justify-content-center nav nav-tabs alert alert-link p-2 m-0"" role=""tablist"" id=""navtabpr"" style=""width: fit-content;"">
                <li class=""alert alert-dark p-2 m-2""><a href=""#hometab"" class=""active"" role=""tab"" data-toggle=""tab"">Short Description</a></li>
                <li class=""alert alert-dark p-2 m-2""><a href=""#javatab"" role=""tab"" data-toggle=""tab"">Full Description</a></li>
                <li class=""alert alert-dark p-2 m-2""><a href=""#csharptab"" role=""tab"" data-toggle=""tab"">Comments</a></li>

            </ul>

            <!-- Tab panes -->
            <div class=""tab-content"" style=""min-width: 100%;"">
                <div class=""tab-pane active"" id=""hometab"">
                    <div class=""col-lg-12 my-5"" style=""margin-left: auto; margin-right: auto;"">
                        <div class");
            WriteLiteral(@"=""card text-center"">
                            <div class=""card-header"">
                                <span style=""font-size: 24px !important;"" class=""font-weight-bold text-facebook"">Short Description</span>
                            </div>
                            <div class=""card-body"">
                                <div class=""alert-light bg-dark-light2 p-5"" style=""color: white !important;"">");
#nullable restore
#line 151 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                        Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""tab-pane"" id=""javatab"">
                    <div class=""col-lg-12 my-5"" style=""margin-left: auto; margin-right: auto;"">
                        <div class=""card text-center"">
                            <div class=""card-header"">
                                <span style=""font-size: 24px !important;"" class=""font-weight-bold text-facebook"">Product Description</span>
                            </div>
                            <div class=""card-body"">
                                <div class=""alert-light bg-dark-light2 p-5"" style=""color: white !important;"">");
#nullable restore
#line 163 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                        Write(Model.FullDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""tab-pane"" id=""csharptab"">
                    <div class=""col-lg-12 my-5"" style=""margin-left: auto; margin-right: auto;"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h4 class=""card-title text-center"" style="" font-size: 30px !important; font-weight: 600 !important; color: white !important; margin-bottom: 20px !important;"">Comments</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered text-center"">
                                        <thead>
                                            <tr>
                                                <th class=""tableTrCustom"">
                                                    #
                                                </th>
       ");
            WriteLiteral(@"                                         <th class=""tableTrCustom"">
                                                    Full Name
                                                </th>
                                                <th class=""tableTrCustom"">
                                                    Email
                                                </th>
                                                <th class=""tableTrCustom"">
                                                    Content
                                                </th>
                                                <th class=""tableTrCustom"">
                                                    Created Date
                                                </th>
                                                <th class=""tableTrCustom"">
                                                    Edit
                                                </th>
                                            </tr>
                  ");
            WriteLiteral("                      </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 198 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                              
                                                int counter = 0;
                                                foreach (var item in Model.ProductComments)
                                                {
                                                    counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td style=\"vertical-align: middle !important;\">\r\n                                                            ");
#nullable restore
#line 205 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"vertical-align: middle !important;\">\r\n                                                            ");
#nullable restore
#line 208 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                        Write(item.CommentPost.FullName!=""? item.CommentPost.FullName: item.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"vertical-align: middle !important;\">\r\n                                                            ");
#nullable restore
#line 211 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                        Write(item.CommentPost.Email!=""? item.CommentPost.Email:item.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </td>
                                                        <td style=""vertical-align: middle !important; width: 320px !important;"">
                                                            <marquee behavior=""scroll"" direction=""up"" height=""100""
                                                                     scrollamount=""2"" scrolldelay=""10"">
                                                                ");
#nullable restore
#line 216 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                           Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            </marquee>
                                                        </td>
                                                        <td style=""vertical-align: middle !important;"">
                                                            ");
#nullable restore
#line 220 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                       Write(item.CreatedDate.ToString("d.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"vertical-align: middle !important;\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b020dd0531b01d6c94401fe9f71da974424fb2233477", async() => {
                WriteLiteral("<i class=\"fal fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 223 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"
                                                                                                                                                                                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 226 "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Shop\ProductDetail.cshtml"


                                                    TempData["ProdIdForAction"] = Model.Id;

                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


                

                
");
            WriteLiteral("            </div>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591