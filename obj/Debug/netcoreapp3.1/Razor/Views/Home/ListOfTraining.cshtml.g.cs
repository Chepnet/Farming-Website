#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fdba172f84ceaedb511ee69cac273bccbec7ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListOfTraining), @"mvc.1.0.view", @"/Views/Home/ListOfTraining.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdba172f84ceaedb511ee69cac273bccbec7ddd", @"/Views/Home/ListOfTraining.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a350381296eab9b18303147657baccf3f41347", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListOfTraining : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
  

    ViewData["Title"] = "Training List";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>List of Training</h2>\r\n<div>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 10 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
   Write(Html.ActionLink("Search", "Index1", "FarmersTrainings"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>

    <table class=""table"">
        <tr>
            <th>
                Trainer Name
            </th>
            <th>
                Event Name
            </th>
            <th>
                Description
            </th>
            <th>
                Training Time
            </th>
            <th>
                Cost of Training
            </th>
            <th></th>
        </tr>

");
#nullable restore
#line 33 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(item.TrainerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(item.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(item.TrainingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
               Write(Html.ActionLink(" View Details", "Details", new { id = item.TrainingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\ListOfTraining.cshtml"
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
