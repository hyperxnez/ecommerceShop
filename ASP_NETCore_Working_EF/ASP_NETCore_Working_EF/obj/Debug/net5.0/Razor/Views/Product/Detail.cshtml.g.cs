#pragma checksum "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "827b75aaa6449655c823abe4b1bd6224ba6e24c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
using ASP_NETCore_Working_EF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"827b75aaa6449655c823abe4b1bd6224ba6e24c4", @"/Views/Product/Detail.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script language=""javascript"" type=""text/javascript"">
    function adjustQuantity(op) {
        var effect = document.getElementById('qty');
        var qty = effect.value;
        switch (op) {
            case 0:
                effect.value++;
                break;
            case 1:
                if (qty != 1) {
                    effect.value--;
                }
                break;
        };
        return false;
    }
</script>

<div class=""single-product-area section-padding-100 clearfix"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mt-50"">
                        <li class=""breadcrumb-item""><a href=""Home/Index"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 30 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
                                                            Write(Model.CateId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 31 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
                                                                           Write(Model.Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ol>
                </nav>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-12 col-lg-7"">
                <div class=""single_product_thumb"">
                    <div id=""product_details_slider"" class=""carousel slide"" data-ride=""carousel"">
                        <ol class=""carousel-indicators"">
                            <li class=""active"" data-target=""#product_details_slider"" data-slide-to=""0""");
            BeginWriteAttribute("style", " style=\"", 1531, "\"", 1577, 4);
            WriteAttributeValue("", 1539, "background-image:", 1539, 17, true);
            WriteAttributeValue(" ", 1556, "url(", 1557, 5, true);
#nullable restore
#line 42 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1561, Model.Image, 1561, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1575, ");", 1575, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </li>\r\n                        </ol>\r\n                        <div class=\"carousel-inner\">\r\n                            <div class=\"carousel-item active\">\r\n                                <a class=\"gallery_img\"");
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1840, 1);
#nullable restore
#line 47 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1826, Model.Image, 1826, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1906, "\"", 1926, 1);
#nullable restore
#line 48 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1912, Model.Image, 1912, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""First slide"">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-lg-5"">
                <div class=""single_product_desc"">
                    <!-- Product Meta Data -->
                    <div class=""product-meta-data"">
                        <div class=""line""></div>
                        <p class=""product-price"">$");
#nullable restore
#line 60 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
                                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a href=\"product-details.html\">\r\n                            <h6>");
#nullable restore
#line 62 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
                            Write(Model.Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        </a>
                        <!-- Ratings & Review -->
                        <div class=""ratings-review mb-15 d-flex align-items-center justify-content-between"">
                            <div class=""ratings"">
                                <i class=""fa fa-star"" aria-hidden=""true""></i>
                                <i class=""fa fa-star"" aria-hidden=""true""></i>
                                <i class=""fa fa-star"" aria-hidden=""true""></i>
                                <i class=""fa fa-star"" aria-hidden=""true""></i>
                                <i class=""fa fa-star"" aria-hidden=""true""></i>
                            </div>
                            <div class=""review"">
                                <a href=""#"">Write A Review</a>
                            </div>
                        </div>
                        <!-- Avaiable -->
                        <p class=""avaibility""><i class=""fa fa-circle""></i> In Stock</p>
                    </div>

");
            WriteLiteral("                    <div class=\"short_overview my-5\">\r\n                        <p>");
#nullable restore
#line 82 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <!-- Add to Cart Form -->\r\n                    <form class=\"cart clearfix\" action=\"/Cart/Add\" method=\"post\">\r\n                        <input hidden name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 3885, "\"", 3907, 1);
#nullable restore
#line 87 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3893, Model.Pname, 3893, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input hidden name=\"Price\"");
            BeginWriteAttribute("value", " value=\"", 3963, "\"", 3985, 1);
#nullable restore
#line 88 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3971, Model.Price, 3971, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input hidden name=\"pid\"");
            BeginWriteAttribute("value", " value=\"", 4039, "\"", 4059, 1);
#nullable restore
#line 89 "C:\Users\hyper\Documents\GitHub\ecommerceShop\ASP_NETCore_Working_EF\ASP_NETCore_Working_EF\Views\Product\Detail.cshtml"
WriteAttributeValue("", 4047, Model.Pid, 4047, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""cart-btn d-flex mb-50"">
                            <p>Qty</p>
                            <div class=""quantity"">
                                <span class=""qty-minus"" onclick=""adjustQuantity(1)""><i class=""fa fa-caret-down"" aria-hidden=""true""></i></span>
                                <input type=""number"" class=""qty-text"" id=""qty"" step=""1"" min=""1"" max=""300"" name=""Quantity"" value=""1"">
                                <span class=""qty-plus"" onclick=""adjustQuantity(0)""><i class=""fa fa-caret-up"" aria-hidden=""true""></i></span>
                            </div>
                        </div>
                        <button type=""submit"" name=""addtocart"" value=""5"" class=""btn amado-btn"">Add to cart</button>
                    </form>

                </div>
            </div>
        </div>
    </div>
</div>");
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
