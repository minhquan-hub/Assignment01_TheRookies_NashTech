#pragma checksum "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Views\Shop\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a224a2b983c0068e1c8dcf71760638bcdfe19fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_CheckOut), @"mvc.1.0.view", @"/Views/Shop/CheckOut.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a224a2b983c0068e1c8dcf71760638bcdfe19fcd", @"/Views/Shop/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfb5b870654bbc013f36399f4d738876ae350fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("billing-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('images/bg_1.jpg');"">
      <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
          <div class=""col-md-9 ftco-animate text-center"">
          	<p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Checkout</span></p>
            <h1 class=""mb-0 bread"">Checkout</h1>
          </div>
        </div>
      </div>
    </div>

    <section class=""ftco-section"">
      <div class=""container"">
        <div class=""row justify-content-center"">
          <div class=""col-xl-7 ftco-animate"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd5611", async() => {
                WriteLiteral(@"
							<h3 class=""mb-4 billing-heading"">Billing Details</h3>
	          	<div class=""row align-items-end"">
	          		<div class=""col-md-6"">
	                <div class=""form-group"">
	                	<label for=""firstname"">Firt Name</label>
	                  <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1014, "\"", 1028, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t                </div>\r\n\t              </div>\r\n\t              <div class=\"col-md-6\">\r\n\t                <div class=\"form-group\">\r\n\t                \t<label for=\"lastname\">Last Name</label>\r\n\t                  <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1279, "\"", 1293, 0);
                EndWriteAttribute();
                WriteLiteral(@">
	                </div>
                </div>
                <div class=""w-100""></div>
		            <div class=""col-md-12"">
		            	<div class=""form-group"">
		            		<label for=""country"">State / Country</label>
		            		<div class=""select-wrap"">
		                  <div class=""icon""><span class=""ion-ios-arrow-down""></span></div>
		                  <select");
                BeginWriteAttribute("name", " name=\"", 1687, "\"", 1694, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1695, "\"", 1700, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n\t\t                  \t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd7525", async() => {
                    WriteLiteral("France");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd8772", async() => {
                    WriteLiteral("Italy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd10018", async() => {
                    WriteLiteral("Philippines");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd11271", async() => {
                    WriteLiteral("South Korea");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd12524", async() => {
                    WriteLiteral("Hongkong");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd13774", async() => {
                    WriteLiteral("Japan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
		                  </select>
		                </div>
		            	</div>
		            </div>
		            <div class=""w-100""></div>
		            <div class=""col-md-6"">
		            	<div class=""form-group"">
	                	<label for=""streetaddress"">Street Address</label>
	                  <input type=""text"" class=""form-control"" placeholder=""House number and street name"">
	                </div>
		            </div>
		            <div class=""col-md-6"">
		            	<div class=""form-group"">
	                  <input type=""text"" class=""form-control"" placeholder=""Appartment, suite, unit etc: (optional)"">
	                </div>
		            </div>
		            <div class=""w-100""></div>
		            <div class=""col-md-6"">
		            	<div class=""form-group"">
	                	<label for=""towncity"">Town / City</label>
	                  <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2992, "\"", 3006, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t                </div>\r\n\t\t            </div>\r\n\t\t            <div class=\"col-md-6\">\r\n\t\t            \t<div class=\"form-group\">\r\n\t\t            \t\t<label for=\"postcodezip\">Postcode / ZIP *</label>\r\n\t                  <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3261, "\"", 3275, 0);
                EndWriteAttribute();
                WriteLiteral(@">
	                </div>
		            </div>
		            <div class=""w-100""></div>
		            <div class=""col-md-6"">
	                <div class=""form-group"">
	                	<label for=""phone"">Phone</label>
	                  <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3558, "\"", 3572, 0);
                EndWriteAttribute();
                WriteLiteral(@">
	                </div>
	              </div>
	              <div class=""col-md-6"">
	                <div class=""form-group"">
	                	<label for=""emailaddress"">Email Address</label>
	                  <input type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3831, "\"", 3845, 0);
                EndWriteAttribute();
                WriteLiteral(@">
	                </div>
                </div>
                <div class=""w-100""></div>
                <div class=""col-md-12"">
                	<div class=""form-group mt-4"">
										<div class=""radio"">
										  <label class=""mr-3""><input type=""radio"" name=""optradio""> Create an Account? </label>
										  <label><input type=""radio"" name=""optradio""> Ship to different address</label>
										</div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- END -->
					</div>
					<div class=""col-xl-5"">
	          <div class=""row mt-5 pt-3"">
	          	<div class=""col-md-12 d-flex mb-5"">
	          		<div class=""cart-detail cart-total p-3 p-md-4"">
	          			<h3 class=""billing-heading mb-4"">Cart Total</h3>
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
		    					<hr>
		    					<p class=""d-flex total-price"">
		    						<span>Total</span>
		    						<span>$17.60</span>
		    					</p>
								</div>
	          	</div>
	          	<div class=""col-md-12"">
	          		<div class=""cart-detail p-3 p-md-4"">
	          			<h3 class=""billing-heading mb-4"">Payment Method</h3>
									<div class=""form-group"">
										<div class=""col-md-12"">
");
            WriteLiteral(@"											<div class=""radio"">
											   <label><input type=""radio"" name=""optradio"" class=""mr-2""> Direct Bank Tranfer</label>
											</div>
										</div>
									</div>
									<div class=""form-group"">
										<div class=""col-md-12"">
											<div class=""radio"">
											   <label><input type=""radio"" name=""optradio"" class=""mr-2""> Check Payment</label>
											</div>
										</div>
									</div>
									<div class=""form-group"">
										<div class=""col-md-12"">
											<div class=""radio"">
											   <label><input type=""radio"" name=""optradio"" class=""mr-2""> Paypal</label>
											</div>
										</div>
									</div>
									<div class=""form-group"">
										<div class=""col-md-12"">
											<div class=""checkbox"">
											   <label><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 6199, "\"", 6207, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2""> I have read and accept the terms and conditions</label>
											</div>
										</div>
									</div>
									<p><a href=""#""class=""btn btn-primary py-3 px-4"">Place an order</a></p>
								</div>
	          	</div>
	          </div>
          </div> <!-- .col-md-8 -->
        </div>
      </div>
    </section> <!-- .section -->

		<section class=""ftco-section ftco-no-pt ftco-no-pb py-5 bg-light"">
      <div class=""container py-4"">
        <div class=""row d-flex justify-content-center py-5"">
          <div class=""col-md-6"">
          	<h2 style=""font-size: 22px;"" class=""mb-0"">Subcribe to our Newsletter</h2>
          	<span>Get e-mail updates about our latest shops and special offers</span>
          </div>
          <div class=""col-md-6 d-flex align-items-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a224a2b983c0068e1c8dcf71760638bcdfe19fcd22064", async() => {
                WriteLiteral("\r\n              <div class=\"form-group d-flex\">\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Enter email address\">\r\n                <input type=\"submit\" value=\"Subscribe\" class=\"submit px-3\">\r\n              </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
		$(document).ready(function(){

		var quantitiy=0;
		   $('.quantity-right-plus').click(function(e){
		        
		        // Stop acting like a button
		        e.preventDefault();
		        // Get the field name
		        var quantity = parseInt($('#quantity').val());
		        
		        // If is not undefined
		            
		            $('#quantity').val(quantity + 1);

		          
		            // Increment
		        
		    });

		     $('.quantity-left-minus').click(function(e){
		        // Stop acting like a button
		        e.preventDefault();
		        // Get the field name
		        var quantity = parseInt($('#quantity').val());
		        
		        // If is not undefined
		      
		            // Increment
		            if(quantity>0){
		            $('#quantity').val(quantity - 1);
		            }
		    });
		    
		});
	</script>");
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
