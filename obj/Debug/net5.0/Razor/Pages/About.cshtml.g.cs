#pragma checksum "D:\TriOS Diploma Work\C_ASP_NET_core\finalProject\final_hotel\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a09236533def32d3ea77f0f5671230b1f22ce0eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(final_hotel.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace final_hotel.Pages
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
#line 1 "D:\TriOS Diploma Work\C_ASP_NET_core\finalProject\final_hotel\Pages\_ViewImports.cshtml"
using final_hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09236533def32d3ea77f0f5671230b1f22ce0eb", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94103178d4ef1938862e4f2655e1d79cc3fa57a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div  class=""text-center full_bg hyatt_p_cont "">
    <h1  class=""display-4 hyatt_p"" >HYATT</h1>
    <p  class=""booking""><a class=""booking-link"" href=""/BookingDate"">New booking</a> | <a class=""booking-link"" href=""/login"">Your booking</a></pHYATT>
</div>

<section>
    <h1>About HYATT</h1>
    <p style=""max-width: 400px;"">
        Hyatt Hotels Corporation, commonly known as Hyatt Hotels & Resorts, is an American multinational hospitality company headquartered in the Riverside Plaza area of Chicago that manages and franchises luxury and business hotels, resorts, and vacation properties. 
    </p>
</section>   
<div class=""container"">
    <div class=""row"">
        <div  class=""col-md img-col "" >
            <img width=""100%"" src=""img/pool.png""");
            BeginWriteAttribute("alt", " alt=\"", 816, "\"", 822, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""col-md "" >
            <h1>OUR story</h1>
            <p> Hyatt was founded by Jay Pritzker in 1957 when he purchased the Hyatt House motel adjacent to the Los Angeles International Airport. Over the following decade, Jay Pritzker and his brother, Donald Pritzker, working together with other Pritzker family business interests, grew the company into a North American management and hotel ownership company, which became a public company in 1962. In 1968, Hyatt International was formed and subsequently became a separate public company. Hyatt Corporation and Hyatt International Corporation were taken private by the Pritzker family business interests in 1979 and 1982, respectively. On December 31, 2004, substantially all of the hospitality assets owned by Pritzker family business interests, including Hyatt Corporation and Hyatt International Corporation, were consolidated under a single entity, now Hyatt Hotels Corporation.</p>
        </div>
    </div>
</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<final_hotel.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<final_hotel.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<final_hotel.Pages.AboutModel>)PageContext?.ViewData;
        public final_hotel.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591