#pragma checksum "/Users/preetibhosale/Downloads/GIT/P3SLeasing/Areas/Unregistered/Views/Unreg/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68bac8362fbcb9893def52eb023622947030339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Unregistered_Views_Unreg_Index), @"mvc.1.0.view", @"/Areas/Unregistered/Views/Unreg/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Unregistered/Views/Unreg/Index.cshtml", typeof(AspNetCore.Areas_Unregistered_Views_Unreg_Index))]
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
#line 1 "/Users/preetibhosale/Downloads/GIT/P3SLeasing/Areas/Unregistered/Views/_ViewImports.cshtml"
using RentQuest;

#line default
#line hidden
#line 2 "/Users/preetibhosale/Downloads/GIT/P3SLeasing/Areas/Unregistered/Views/_ViewImports.cshtml"
using RentQuest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68bac8362fbcb9893def52eb023622947030339", @"/Areas/Unregistered/Views/Unreg/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d613e96bde3ff60efbb1fcbcf79566827cbc7cc2", @"/Areas/Unregistered/Views/_ViewImports.cshtml")]
    public class Areas_Unregistered_Views_Unreg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Unregistered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Unreg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link ml-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/preetibhosale/Downloads/GIT/P3SLeasing/Areas/Unregistered/Views/Unreg/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 602, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light"" id=""ftco-navbar"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""index.html"">P3S<span>Leasing</span></a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""oi oi-menu""></span> Menu
        </button>

        <div class=""collapse navbar-collapse"" id=""ftco-nav"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item"">");
            EndContext();
            BeginContext(644, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68bac8362fbcb9893def52eb0236229470303396592", async() => {
                BeginContext(730, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("</li>\n                <li class=\"nav-item\">");
            EndContext();
            BeginContext(781, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68bac8362fbcb9893def52eb0236229470303398465", async() => {
                BeginContext(869, 8, true);
                WriteLiteral("Property");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(881, 47, true);
            WriteLiteral("</li>\n                <li class=\"nav-item cta\">");
            EndContext();
            BeginContext(928, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68bac8362fbcb9893def52eb02362294703033910346", async() => {
                BeginContext(1021, 39, true);
                WriteLiteral("<span class=\"icon-user\"></span> Sign-In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1064, 59, true);
            WriteLiteral("</li>\n                <li class=\"nav-item cta cta-colored\">");
            EndContext();
            BeginContext(1123, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68bac8362fbcb9893def52eb02362294703033912277", async() => {
                BeginContext(1209, 41, true);
                WriteLiteral("<span class=\"icon-pencil\"></span> Sign-Up");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1254, 8442, true);
            WriteLiteral(@"</li>

            </ul>
        </div>
    </div>
</nav>

<section class=""home-slider owl-carousel"">
    <div class=""slider-item"" style=""background-image:url(/Content/images/bp.jpg);"">
        <div class=""overlay""></div>
    </div>


    <div class=""slider-item"" style=""background-image:url(/Content/images/b.jpg);"">
        <div class=""overlay""></div>
    </div>



    <div class=""slider-item"" style=""background-image:url(/Content/images/bg_2.jpg);"">
        <div class=""overlay""></div>
    </div>
</section>

<section class=""ftco-section ftco-properties"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-3"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <span class=""subheading"">Recent Posts</span>
                <h2 class=""mb-4"">Recent Properties</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""properties-slider owl-carousel ftco-animate"">
              ");
            WriteLiteral(@"      <div class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/properties-1.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
                                </div>
                            </a>
                            <div class=""text p-3"">
                                <span class=""status sale"">Sale</span>
                                <div class=""d-flex"">
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                                        <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$20,000</s");
            WriteLiteral(@"pan>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/properties-2.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
                                </div>
                            </a>
                            <div class=""text p-3"">
                                <div class=""d-flex"">
                                    <span class=""status rent"">Rent</span>
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                          ");
            WriteLiteral(@"              <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$2,000 <small>/ month</small></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/properties-3.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
                                </div>
                            </a>
                            <div class=""text p-3"">
                                <span class=""status sale"">Sale</span>
     ");
            WriteLiteral(@"                           <div class=""d-flex"">
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                                        <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$20,000</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/properties-4.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
    ");
            WriteLiteral(@"                            </div>
                            </a>
                            <div class=""text p-3"">
                                <span class=""status sale"">Sale</span>
                                <div class=""d-flex"">
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                                        <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$20,000</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/pr");
            WriteLiteral(@"operties-5.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
                                </div>
                            </a>
                            <div class=""text p-3"">
                                <span class=""status rent"">Rent</span>
                                <div class=""d-flex"">
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                                        <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$900 <small>/ month</small></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <d");
            WriteLiteral(@"iv class=""item"">
                        <div class=""properties"">
                            <a href=""#"" class=""img d-flex justify-content-center align-items-center"" style=""background-image: url(/Content/images/properties-6.jpg);"">
                                <div class=""icon d-flex justify-content-center align-items-center"">
                                    <span class=""icon-search2""></span>
                                </div>
                            </a>
                            <div class=""text p-3"">
                                <span class=""status sale"">Sale</span>
                                <div class=""d-flex"">
                                    <div class=""one"">
                                        <h3><a href=""#"">North Parchmore Street</a></h3>
                                        <p>Apartment</p>
                                    </div>
                                    <div class=""two"">
                                        <span class=""price"">$20,000</span>
   ");
            WriteLiteral("                                 </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
            EndContext();
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
