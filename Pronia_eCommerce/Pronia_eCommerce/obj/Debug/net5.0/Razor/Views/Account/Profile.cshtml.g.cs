#pragma checksum "C:\Users\ASUS\Desktop\Pronia_eCommerce_Project\Pronia_eCommerce\Pronia_eCommerce\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327a8571cc442d861927736cd63669970dcbbfe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327a8571cc442d861927736cd63669970dcbbfe8", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3fe617c7a990291cc5191a30ff3477ba347ac8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myaccount-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<!-- #region Account -->
<div class=""account-full pt-100 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <ul class=""nav"" id=""account-page-tab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Dashboard</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Orders</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-address-tab"" data-bs-toggle=""tab"" href=""#account-address"" role=""tab"" aria-controls=""account-address"" aria-selected=""false"">Addresses</a>
                  ");
            WriteLiteral(@"  </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Account Details</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-logout-tab"" href=""login-register.html"" role=""tab"" aria-selected=""false"">Logout</a>
                    </li>
                </ul>
            </div>
            <div class=""col-lg-9"">
                <div class=""tab-content"" id=""account-page-tab-content"">
                    <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                        <div class=""myaccount-dashboard"">
                            <p>
                                Hello <b>Pronia</b> (not Pronia? <a href=""login-register.html"">
                                    Sign
            ");
            WriteLiteral(@"                        out
                                </a>)
                            </p>
                            <p>
                                From your account dashboard you can view your recent orders, manage your shipping and
                                billing addresses and <a href=""#"">edit your password and account details</a>.
                            </p>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                        <div class=""myaccount-orders"">
                            <h4 class=""small-title"">MY ORDERS</h4>
                            <div class=""table-responsive"">
                                <table class=""table table-bordered table-hover"">
                                    <tbody>
                                        <tr class=""make-it-unvisible"">
                                            <th>ORDER</th>
");
            WriteLiteral(@"                                            <th>DATE</th>
                                            <th>STATUS</th>
                                            <th>TOTAL</th>
                                            <th></th>
                                        </tr>
                                        <tr>
                                            <td><a class=""account-order-id"" href=""#"">#5364</a></td>
                                            <td>Mar 27, 2019</td>
                                            <td>On Hold</td>
                                            <td>$162.00 for 2 items</td>
                                            <td>
                                                <a href=""#"" class=""btn btn-dark""><span>View</span></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><a class=""account-order-id"" href=""#"">#5356</a>");
            WriteLiteral(@"</td>
                                            <td>Mar 27, 2019</td>
                                            <td>On Hold</td>
                                            <td>$162.00 for 2 items</td>
                                            <td>
                                                <a href=""#"" class=""btn btn-dark""><span>View</span></a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                        <div class=""myaccount-address"">
                            <p>The following addresses will be used on the checkout page by default.</p>
                            <div class=""row"">
                                <div class=""");
            WriteLiteral(@"col"">
                                    <h4 class=""small-title"">BILLING ADDRESS</h4>
                                    <address>
                                        1234 Heaven Stress, Beverly Hill OldYork UnitedState of Lorem
                                    </address>
                                </div>
                                <div class=""col"">
                                    <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                    <address>
                                        1234 Heaven Stress, Beverly Hill OldYork UnitedState of Lorem
                                    </address>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                        <div class=""myaccount-details"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327a8571cc442d861927736cd63669970dcbbfe810702", async() => {
                WriteLiteral(@"
                                <div class=""myaccount-form-inner"">
                                    <div class=""single-input single-input-half"">
                                        <label>First Name*</label>
                                        <input type=""text"">
                                    </div>
                                    <div class=""single-input single-input-half"">
                                        <label>Last Name*</label>
                                        <input type=""text"">
                                    </div>
                                    <div class=""single-input"">
                                        <label>Email*</label>
                                        <input type=""email"">
                                    </div>
                                    <div class=""single-input"">
                                        <label>
                                            Current Password(leave blank to leave
                ");
                WriteLiteral(@"                            unchanged)
                                        </label>
                                        <input type=""password"">
                                    </div>
                                    <div class=""single-input"">
                                        <label>
                                            New Password (leave blank to leave
                                            unchanged)
                                        </label>
                                        <input type=""password"">
                                    </div>
                                    <div class=""single-input"">
                                        <label>Confirm New Password</label>
                                        <input type=""password"">
                                    </div>
                                    <div class=""single-input"">
                                        <button class=""btn"" type=""submit"">
                           ");
                WriteLiteral("                 <span>SAVE CHANGES</span>\r\n                                        </button>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- #endregion Account End -->");
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