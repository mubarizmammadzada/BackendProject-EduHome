#pragma checksum "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8f4d48d4d235f1fb8a119ffad1d35d9fbbfd6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_AdminRole_Index), @"mvc.1.0.view", @"/Areas/admin/Views/AdminRole/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/admin/Views/AdminRole/Index.cshtml", typeof(AspNetCore.Areas_admin_Views_AdminRole_Index))]
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
#line 1 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\_ViewImports.cshtml"
using BackendProject.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\_ViewImports.cshtml"
using BackendProject.Areas.admin.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\_ViewImports.cshtml"
using BackendProject.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8f4d48d4d235f1fb8a119ffad1d35d9fbbfd6d", @"/Areas/admin/Views/AdminRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62620fa4a600e66036171534adce50e02ec646c", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_AdminRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(60, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(89, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af457b27ea264215ba0af57faba7c285", async() => {
                BeginContext(95, 304, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(408, 2458, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb7ec7335d645e588b8a8a463dc0feb", async() => {
                BeginContext(414, 627, true);
                WriteLiteral(@"
    <div class=""container"">
        <h1 class=""text-danger text-center"">Change Users Role</h1>
        <div class=""row"">
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Username</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Fullname</th>
                        <th scope=""col"">Role</th>
                        <th scope=""col"">Delete</th>
                        <th scope=""col"">Admin</th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 30 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                     foreach (UserVM user in Model.Where(u => u.IsDeletedet == false))
                    {

#line default
#line hidden
                BeginContext(1152, 62, true);
                WriteLiteral("                        <tr>\r\n                            <th>");
                EndContext();
                BeginContext(1215, 13, false);
#line 33 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                           Write(user.Username);

#line default
#line hidden
                EndContext();
                BeginContext(1228, 39, true);
                WriteLiteral("</th>\r\n                            <td>");
                EndContext();
                BeginContext(1268, 10, false);
#line 34 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                           Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1278, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1318, 13, false);
#line 35 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                           Write(user.Fullname);

#line default
#line hidden
                EndContext();
                BeginContext(1331, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1371, 9, false);
#line 36 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                           Write(user.Role);

#line default
#line hidden
                EndContext();
                BeginContext(1380, 41, true);
                WriteLiteral("</td>\r\n                            <td>\r\n");
                EndContext();
#line 38 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                 if (user.Role != Helper.UserRoles.Admin.ToString())
                                {

#line default
#line hidden
                BeginContext(1542, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1578, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f809553177df452f94bf33e93f7475f8", async() => {
                    BeginContext(1685, 11, true);
                    WriteLiteral("Delete User");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                                                                               WriteLiteral(user.Email);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1700, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"

                                }

#line default
#line hidden
                BeginContext(1739, 103, true);
                WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1842, 840, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b36777068b3477b9f61aebf8de73406", async() => {
                    BeginContext(1885, 66, true);
                    WriteLiteral("\r\n                                    <select name=\"rolename\">\r\n\r\n");
                    EndContext();
#line 49 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                         foreach (string item in Enum.GetNames(typeof(Helper.UserRoles)))
                                        {
                                            

#line default
#line hidden
#line 51 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                             if (item != @user.Role)
                                            {

#line default
#line hidden
                    BeginContext(2218, 48, true);
                    WriteLiteral("                                                ");
                    EndContext();
                    BeginContext(2266, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "843de5ce4e844572ae919d8f87b5a60a", async() => {
                        BeginContext(2288, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2290, 4, false);
#line 53 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                                                  Write(item);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                                   WriteLiteral(item);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2303, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 54 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                            }

#line default
#line hidden
#line 54 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                                             

                                        }

#line default
#line hidden
                    BeginContext(2397, 116, true);
                    WriteLiteral("                                    </select>\r\n                                    <input type=\"hidden\" name=\"Email\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2513, "\"", 2532, 1);
#line 58 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 2521, user.Email, 2521, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2533, 142, true);
                    WriteLiteral(" />\r\n                                    <input type=\"submit\" class=\"btn btn-success ml-3\" value=\"Change\" />\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2682, 70, true);
                WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
                EndContext();
#line 64 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Areas\admin\Views\AdminRole\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2775, 84, true);
                WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2866, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591