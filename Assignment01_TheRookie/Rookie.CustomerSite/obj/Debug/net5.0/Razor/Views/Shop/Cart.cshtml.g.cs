#pragma checksum "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Views\Shop\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9290b5d39c9783571795f9dfdd0d09e73938c89c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Cart), @"mvc.1.0.view", @"/Views/Shop/Cart.cshtml")]
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
#line 1 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Views\_ViewImports.cshtml"
using Rookie.CustomerSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Views\_ViewImports.cshtml"
using Rookie.CustomerSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9290b5d39c9783571795f9dfdd0d09e73938c89c", @"/Views/Shop/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfb5b870654bbc013f36399f4d738876ae350fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div
  class=""hero-wrap hero-bread""
  style=""background-image: url('images/bg_1.jpg');""
>
  <div class=""container"">
    <div
      class=""row no-gutters slider-text align-items-center justify-content-center""
    >
      <div class=""col-md-9 ftco-animate text-center"">
        <p class=""breadcrumbs"">
          <span class=""mr-2""><a href=""index.html"">Home</a></span>
          <span>Cart</span>
        </p>
        <h1 class=""mb-0 bread"">My Cart</h1>
      </div>
    </div>
  </div>
</div>

<section class=""ftco-section ftco-cart"">
  <div class=""container"">
    <div class=""row"">
      <div class=""col-md-12 ftco-animate"">
        <div class=""cart-list"">
          <table class=""table"">
            <thead class=""thead-primary"">
              <tr class=""text-center"">
                <th>&nbsp;</th>
                <th>&nbsp;</th>
                <th>Product name</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Total</th>
              </tr>
   ");
            WriteLiteral(@"         </thead>
            <tbody>
              <tr class=""text-center"">
                <td class=""product-remove"">
                  <a href=""#""><span class=""ion-ios-close""></span></a>
                </td>

                <td class=""image-prod"">
                  <div
                    class=""img""
                    style=""background-image: url(images/product-3.jpg);""
                  ></div>
                </td>

                <td class=""product-name"">
                  <h3>Bell Pepper</h3>
                  <p>
                    Far far away, behind the word mountains, far from the countries
                  </p>
                </td>

                <td class=""price"">$4.90</td>

                <td class=""quantity"">
                  <div class=""input-group mb-3"">
                    <input
                      type=""text""
                      name=""quantity""
                      class=""quantity form-control input-number""
                      value=""1""
 ");
            WriteLiteral(@"                     min=""1""
                      max=""100""
                    />
                  </div>
                </td>

                <td class=""total"">$4.90</td>
              </tr>
              <!-- END TR-->

              <tr class=""text-center"">
                <td class=""product-remove"">
                  <a href=""#""><span class=""ion-ios-close""></span></a>
                </td>

                <td class=""image-prod"">
                  <div
                    class=""img""
                    style=""background-image: url(images/product-4.jpg);""
                  ></div>
                </td>

                <td class=""product-name"">
                  <h3>Bell Pepper</h3>
                  <p>
                    Far far away, behind the word mountains, far from the countries
                  </p>
                </td>

                <td class=""price"">$15.70</td>

                <td class=""quantity"">
                  <div class=""input-group mb-3"">
    ");
            WriteLiteral(@"                <input
                      type=""text""
                      name=""quantity""
                      class=""quantity form-control input-number""
                      value=""1""
                      min=""1""
                      max=""100""
                    />
                  </div>
                </td>

                <td class=""total"">$15.70</td>
              </tr>
              <!-- END TR-->
            </tbody>
          </table>
        </div>
      </div>
    </div>
    <div class=""row justify-content-end"">
      <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
        <div class=""cart-total mb-3"">
          <h3>Coupon Code</h3>
          <p>Enter your coupon code if you have one</p>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290b5d39c9783571795f9dfdd0d09e73938c89c8505", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 3919, "\"", 3925, 0);
                EndWriteAttribute();
                WriteLiteral(">Coupon code</label>\r\n              <input\r\n                type=\"text\"\r\n                class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", "\r\n                placeholder=\"", 4050, "\"", 4081, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n              />\r\n            </div>\r\n          ");
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
            WriteLiteral(@"
        </div>
        <p>
          <a href=""checkout"" class=""btn btn-primary py-3 px-4"">Apply Coupon</a>
        </p>
      </div>
      <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
        <div class=""cart-total mb-3"">
          <h3>Estimate shipping and tax</h3>
          <p>Enter your destination to get a shipping estimate</p>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290b5d39c9783571795f9dfdd0d09e73938c89c10855", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 4590, "\"", 4596, 0);
                EndWriteAttribute();
                WriteLiteral(">Country</label>\r\n              <input\r\n                type=\"text\"\r\n                class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", "\r\n                placeholder=\"", 4717, "\"", 4748, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n              />\r\n            </div>\r\n            <div class=\"form-group\">\r\n              <label for=\"country\">State/Province</label>\r\n              <input\r\n                type=\"text\"\r\n                class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", "\r\n                placeholder=\"", 4988, "\"", 5019, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n              />\r\n            </div>\r\n            <div class=\"form-group\">\r\n              <label for=\"country\">Zip/Postal Code</label>\r\n              <input\r\n                type=\"text\"\r\n                class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", "\r\n                placeholder=\"", 5260, "\"", 5291, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n              />\r\n            </div>\r\n          ");
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
            WriteLiteral(@"
        </div>
        <p><a href=""checkout"" class=""btn btn-primary py-3 px-4"">Estimate</a></p>
      </div>
      <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
        <div class=""cart-total mb-3"">
          <h3>Cart Totals</h3>
          <p class=""d-flex"">
            <span>Subtotal</span>
            <span>$20.60</span>
          </p>
          <p class=""d-flex"">
            <span>Delivery</span>
            <span>$0.00</span>
          </p>
          <p class=""d-flex"">
            <span>Discount</span>
            <span>$3.00</span>
          </p>
          <hr />
          <p class=""d-flex total-price"">
            <span>Total</span>
            <span>$17.60</span>
          </p>
        </div>
        <p>
          <a href=""checkout"" class=""btn btn-primary py-3 px-4"">
            Proceed to Checkout
          </a>
        </p>
      </div>
    </div>
  </div>
</section>

<section class=""ftco-section ftco-no-pt ftco-no-pb py-5 bg-light"">
  <div class=""container p");
            WriteLiteral(@"y-4"">
    <div class=""row d-flex justify-content-center py-5"">
      <div class=""col-md-6"">
        <h2 style=""font-size: 22px;"" class=""mb-0"">
          Subcribe to our Newsletter
        </h2>
        <span>
          Get e-mail updates about our latest shops and special offers
        </span>
      </div>
      <div class=""col-md-6 d-flex align-items-center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9290b5d39c9783571795f9dfdd0d09e73938c89c15199", async() => {
                WriteLiteral(@"
          <div class=""form-group d-flex"">
            <input
              type=""text""
              class=""form-control""
              placeholder=""Enter email address""
            />
            <input type=""submit"" value=""Subscribe"" class=""submit px-3"" />
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
    </div>
  </div>
</section>

<script>
  $(document).ready(function () {
    var quantitiy = 0
    $('.quantity-right-plus').click(function (e) {
      // Stop acting like a button
      e.preventDefault()

      // Get the field name
      var quantity = parseInt($('#quantity').val())

      // If is not undefined
      $('#quantity').val(quantity + 1)
      // Increment
    })

    $('.quantity-left-minus').click(function (e) {
      // Stop acting like a button
      e.preventDefault()

      // Get the field name
      var quantity = parseInt($('#quantity').val())

      // If is not undefined
      // Increment
      if (quantity > 0) {
        $('#quantity').val(quantity - 1)
      }
    })
  })
</script>
");
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
