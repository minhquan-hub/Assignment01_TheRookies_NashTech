#pragma checksum "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313e8383800aabe559d48b5a7e91451c372abca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Product_UploadImage), @"mvc.1.0.razor-page", @"/Pages/Product/UploadImage.cshtml")]
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
#line 2 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
using Rookie.ShareClass.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
using Rookie.CustomerSite.Pages.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313e8383800aabe559d48b5a7e91451c372abca2", @"/Pages/Product/UploadImage.cshtml")]
    public class Pages_Product_UploadImage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back_link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
  
    ViewData["Title"] = "PhotoAlbum - Direct Upload page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- A form for direct uploading using a jQuery plug-in.
          The BuildUploadForm method generates the required HTML and JavaScript to
          allow uploading directly from the browser to your Cloudinary account -->
<div id=""direct_upload"">
    <h1>Direct upload from the browser</h1>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313e8383800aabe559d48b5a7e91451c372abca25015", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 19 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
         if (Model.DirectUploadType == DirectUploadType.Signed)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
       Write(Html.Raw(Cloudinary.Api.BuildUploadForm("test-field", "auto", new SortedDictionary<string, object> { { "tags", UploadImagePageModel.Tags } }, new Dictionary<string, string> { { "multiple", "true" } })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
                                                                                                                                                                                                                      
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
       Write(Html.Raw(Cloudinary.Api.BuildUnsignedUploadForm("test-field", Model.Preset, "image", new SortedDictionary<string, object> { { "tags", UploadImagePageModel.Tags } }, new Dictionary<string, string> { { "multiple", "true" } })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
                                                                                                                                                                                                                                             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <!-- status box -->\r\n    <div class=\"status\">\r\n        <h2>Status</h2>\r\n        <span class=\"status_value\">Idle</span>\r\n    </div>\r\n\r\n    <div class=\"uploaded_info_holder\">\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313e8383800aabe559d48b5a7e91451c372abca29089", async() => {
                WriteLiteral("Back to list...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("     ");
#nullable restore
#line 44 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
Write(Html.Raw(Cloudinary.GetCloudinaryJsConfig(dir: "js")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  

<script>
    $(function () {

            function prettydump(obj) {
                ret = """"
                $.each(obj, function (key, value) {
                    ret += ""<tr><td>"" + key + ""</td><td>"" + value + ""</td></tr>"";
                });

                return ret;
            }

            $('.cloudinary-fileupload').fileupload({
                dropZone: '#direct_upload',
                start: function () {
                    $('.status_value').text('Starting direct upload...');
                },
                progress: function () {
                    $('.status_value').text('Uploading...');
                },
            })
            .bind('fileuploaddone', function (e, data) {
                $('.status_value').text('Idle');

                $.ajax({
                    type: ""POST"",
                    url: '");
#nullable restore
#line 72 "F:\STORAGE_APPLICATION\G\Git\Assignment01_Real\Assignment01_TheRookies_NashTech\Assignment01_TheRookie\Rookie.CustomerSite\Pages\Product\UploadImage.cshtml"
                     Write(Url.Page("/UploadDirectly"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: JSON.stringify(data.result),
                    contentType: 'application/json; charset=utf-8',
                    headers: { ""RequestVerificationToken"": $('input[name=""__RequestVerificationToken""]').val()}
                });

                var info = $('<div class=""uploaded_info""/>');
                $(info).append($('<div class=""data""/>').append(prettydump(data.result)));
                $(info).append($('<div class=""image""/>').append(
                  $.cloudinary.image(data.result.public_id, {
                      format: data.result.format,
                      width: 150,
                      height: 150,
                      crop: ""fill""
                  })
                ));
                $('.uploaded_info_holder').append(info);
            })
            .bind('fileuploadfail', function (e, data) {
                $('.status_value').text('Upload error!');
            });
        });
</script>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Cloudinary Cloudinary { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rookie.CustomerSite.Pages.Product.UploadImagePageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rookie.CustomerSite.Pages.Product.UploadImagePageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rookie.CustomerSite.Pages.Product.UploadImagePageModel>)PageContext?.ViewData;
        public Rookie.CustomerSite.Pages.Product.UploadImagePageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
