#pragma checksum "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b9f2d564217a4f07e365faedba5a19d821a54f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_CreateOrder), @"mvc.1.0.view", @"/Views/Sales/CreateOrder.cshtml")]
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
#line 1 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b9f2d564217a4f07e365faedba5a19d821a54f", @"/Views/Sales/CreateOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd5e81157aaadf292c89301cd5c1be8ee9a165", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sales_CreateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.OrderModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<button id=\"rzp-button1\" hidden>Pay</button>\r\n<script src=\"https://checkout.razorpay.com/v1/checkout.js\"></script>\r\n<script>\r\nvar options = {\r\n    \"key\": \"");
#nullable restore
#line 7 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayFor(model => model.razorpayKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", // Enter the Key ID generated from the Dashboard\r\n    \"amount\": \"");
#nullable restore
#line 8 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
          Write(Html.DisplayFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", // Amount is in currency subunits. Default currency is INR. Hence, 50000 refers to 50000 paise\r\n    \"currency\": \"");
#nullable restore
#line 9 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
            Write(Html.DisplayFor(model => model.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"name\": \"");
#nullable restore
#line 10 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
        Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"description\": \"");
#nullable restore
#line 11 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
               Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"image\": \"http://staging.heeranyam.com/WebApp/assets/img/logo/logo.png\", // You can give your logo url\r\n    \"order_id\": \"");
#nullable restore
#line 13 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
            Write(Html.DisplayFor(model => model.orderId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
    ""handler"": function (response){
        // After payment successfully made response will come here
        // Set the data in hidden form
        document.getElementById('rzp_paymentid').value = response.razorpay_payment_id;
        document.getElementById('rzp_orderid').value = response.razorpay_order_id;

        // // Let's submit the form automatically
        document.getElementById('rzp-paymentresponse').click();
    },
    ""prefill"": {
        ""name"": """);
#nullable restore
#line 24 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
            Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"email\": \"");
#nullable restore
#line 25 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
             Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"contact\": \"");
#nullable restore
#line 26 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
               Write(Html.DisplayFor(model => model.contactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    },\r\n    \"notes\": {\r\n        \"address\": \"");
#nullable restore
#line 29 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
               Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
    },
    ""theme"": {
        ""color"": ""#F37254""
    }
};
var rzp1 = new Razorpay(options);

//<!-- onload function -->
window.onload = function(){
    document.getElementById('rzp-button1').click();
};

document.getElementById('rzp-button1').onclick = function(e){
    rzp1.open();
    e.preventDefault();
}
</script>

<!-- This form is hidden, and submit when payment successfully made -->
");
#nullable restore
#line 49 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
 using (Html.BeginForm("Complete", "Sales"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
Write(Html.Hidden("rzp_paymentid"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
Write(Html.Hidden("rzp_orderid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" id=\"rzp-paymentresponse\" class=\"btn btn-primary\" hidden>Submit</button>\r\n");
#nullable restore
#line 56 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Sales\CreateOrder.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<!-- breadcrumb area start -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb-wrap"">
                    <nav aria-label=""breadcrumb"">
                        <ul class=""breadcrumb"">
                            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16b9f2d564217a4f07e365faedba5a19d821a54f9039", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Payment</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb area end -->
<!-- login register wrapper start -->
<div class=""login-register-wrapper section-padding loginBanner"">
    <div class=""container"">
        <div class=""member-area-from-wrap"">
            <div class=""row"">
                <!-- Login Content Start -->
                <div class=""offset-md-12 col-lg-12"">
                    <div class=""login-reg-form-wrap"">
                        <h5>Redirecting to payment gateway... please wait!</h5>
                        <div class=""table-responsive table-desi"">
                            <div class=""minicart-item-wrapper"">


                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>");
            WriteLiteral("\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.OrderModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
