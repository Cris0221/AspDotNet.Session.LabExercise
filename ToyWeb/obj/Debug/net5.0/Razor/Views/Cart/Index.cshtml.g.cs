#pragma checksum "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6830c7c2f26e06e563b540242a31e6dfa9d25d0b"
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
#line 1 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\_ViewImports.cshtml"
using ToyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\_ViewImports.cshtml"
using ToyWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
using ToyData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
using ToyWeb.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6830c7c2f26e06e563b540242a31e6dfa9d25d0b", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9bde83842f2efe94ceaa8495be62d6350dee19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Cart";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Cart Page</h3>\r\n");
#nullable restore
#line 10 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
  
    List<ShoppingCart> emptyCart = Context.Session.GetObject<List<ShoppingCart>>("cart");
    var totalCart = emptyCart.Sum(item => item.CToy.MToyRate * item.SiQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 15 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
 if(@emptyCart.Count != 0)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<table cellpadding=\"2\" cellspacing=\"2\" border=\"1\">\r\n    <tr>\r\n        <th>Option</th>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n        <th>Sub Total</th>\r\n    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
     foreach (ShoppingCart item in @Context.Session.GetObject<List<ShoppingCart>>("cart"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 714, "\"", 781, 1);
#nullable restore
#line 30 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 721, Url.Action("Remove", "Cart", new { id = item.CToy.CToyId }), 721, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a></td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
           Write(item.CToy.CToyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
           Write(item.CToy.VToyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
           Write(item.CToy.MToyRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
           Write(item.SiQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
            Write(item.CToy.MToyRate * item.SiQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n        <td align=\"right\" colspan=\"5\">Sum:</td>\r\n        <td>\r\n");
#nullable restore
#line 41 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
              
                List<ShoppingCart> cart = Context.Session.GetObject<List<ShoppingCart>>("cart");
                var total = cart.Sum(item => item.CToy.MToyRate * item.SiQty);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 45 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<br>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1388, "\"", 1422, 1);
#nullable restore
#line 50 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1395, Url.Action("Index", "Toy"), 1395, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n");
#nullable restore
#line 51 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>cart is empty</h3>\r\n");
#nullable restore
#line 55 "C:\Users\cristobal.fragata\source\repos\AspDotNet.Session.LabExercise\ToyWeb\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
