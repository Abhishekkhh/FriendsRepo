#pragma checksum "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1f34bee2a08f56a3b16ada929dfab5d66c0683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisplayFriends_DisplayFriends), @"mvc.1.0.view", @"/Views/DisplayFriends/DisplayFriends.cshtml")]
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
#line 1 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\_ViewImports.cshtml"
using Friends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
using Friends.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1f34bee2a08f56a3b16ada929dfab5d66c0683", @"/Views/DisplayFriends/DisplayFriends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbe2bb04480e0323afab7e475087bbddba68f3c", @"/Views/_ViewImports.cshtml")]
    public class Views_DisplayFriends_DisplayFriends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisplayFriends>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
  
    ViewBag.Title = "Display Friends";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1f34bee2a08f56a3b16ada929dfab5d66c06833578", async() => {
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1f34bee2a08f56a3b16ada929dfab5d66c06834544", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 13 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
         using (Html.BeginForm("DisplayFriends", "DisplayFriends", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table class=""table"">
                <tr>
                    <th>Action</th>
                    <th>Sr No.</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email ID</th>
                    <th>Mobile No.</th>
                </tr>

");
#nullable restore
#line 25 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                  int i = 1;
                    for (var j = 0; j < Model.Count; j++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 30 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Html.CheckBoxFor(c => c[j].isChecked));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 31 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Html.HiddenFor(c => c[j].FriendId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Html.ActionLink(@Model[j].FirstName, "FriendsDetails", "FriendsDetails", new { FriendId = @Model[j].FriendId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Model[j].LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Model[j].EmailID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                           Write(Model[j].MobileNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                              i++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
                WriteLiteral("            <div class=\"row\">\r\n                <h4 id=\"ErrorMessage\" class=\"alert-danger\">");
#nullable restore
#line 45 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
                                                      Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <button type=\"submit\" class=\"btn btn-danger\" onclick=\"return validatecheckbox();\" value=\"Login\">Delete</button>\r\n                    ");
#nullable restore
#line 51 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
               Write(Html.ActionLink("Create New Friend", "FriendsDetails", "FriendsDetails", null,new { @class="btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\ABHISHEK\source\repos\Friends\Friends\Views\DisplayFriends\DisplayFriends.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <script>
        function validatecheckbox() {
            debugger;
            if ($(""input[type=checkbox]:checked"").length > 0) {
                return true;
            }
            $('#ErrorMessage').text(""Please select atleast one Friend to delete !! "");
            return false;
        }
    </script>
");
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
            WriteLiteral("\r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisplayFriends>> Html { get; private set; }
    }
}
#pragma warning restore 1591