#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4aa2b8c395a0cc8b3978f7f9be6516c95e012b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_Index), @"mvc.1.0.view", @"/Views/Application/Index.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\_ViewImports.cshtml"
using Online_Farmers_Training;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\_ViewImports.cshtml"
using Online_Farmers_Training.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4aa2b8c395a0cc8b3978f7f9be6516c95e012b", @"/Views/Application/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a350381296eab9b18303147657baccf3f41347", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
  

    ViewData["Title"] = "Applications List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"alert-info\" style=\"color:green\">Applicants</h2>\r\n</div>\r\n<div>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 13 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
   Write(Html.ActionLink("Search", "Search", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>

    <table class=""table"">
        <tr>
            <th>
                Event Name
            </th>
            <th>
               First Name
            </th>
            <th>
               Last Name
            </th>
            <th>
                Email
            </th>
            
            <th></th>
        </tr>

");
#nullable restore
#line 34 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
               Write(item.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
               Write(Html.ActionLink(" View Details", "ApplicationDetails", "Application", new { id = item.ApplicationId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n            </tr>  \r\n");
#nullable restore
#line 56 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Application\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>");
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
