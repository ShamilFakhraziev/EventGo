#pragma checksum "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3cd30c32bb73de0dc882dc73786d9a48fe47b2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyProfile), @"mvc.1.0.view", @"/Views/Account/MyProfile.cshtml")]
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
#line 1 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\_ViewImports.cshtml"
using EventGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\_ViewImports.cshtml"
using EventGo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\_ViewImports.cshtml"
using EventGo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3cd30c32bb73de0dc882dc73786d9a48fe47b2c", @"/Views/Account/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3efc4b6dcc0d67668b6c5d9981a8231270ed4c25", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeDeposit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CashOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <p>Логин: ");
#nullable restore
#line 4 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
         Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Имя: ");
#nullable restore
#line 5 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
       Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Email: ");
#nullable restore
#line 6 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
         Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Телефон: ");
#nullable restore
#line 7 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
           Write(Model.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Баланс: ");
#nullable restore
#line 8 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
          Write(Model.User.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" рублей</p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3cd30c32bb73de0dc882dc73786d9a48fe47b2c6198", async() => {
                WriteLiteral("Пополнить счет");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3cd30c32bb73de0dc882dc73786d9a48fe47b2c7652", async() => {
                WriteLiteral("Вывести средства со счета");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div> \n");
#nullable restore
#line 12 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
 if(!User.IsInRole("organizer")){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Мои мероприятия</h2>\n    <table class=\"table mt-2\">\n        <tr><th>Название</th><th>Место проведения</th><th>Дата проведения</th></tr>\n");
#nullable restore
#line 16 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
         foreach (var ev in Model.Events)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 20 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
               Write(ev.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
#nullable restore
#line 22 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
               Write(ev.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>\n                <td>\n                   ");
#nullable restore
#line 26 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
              Write(ev.DateOfTheEvent.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n\n            </tr>\n            <tr></tr>\n");
#nullable restore
#line 31 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n");
#nullable restore
#line 33 "C:\Users\Shamil\Documents\Курсовая\EventGo\EventGo\Views\Account\MyProfile.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
