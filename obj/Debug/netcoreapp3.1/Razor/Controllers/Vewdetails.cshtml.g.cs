#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3aff6cc48c9c7ddab97e8c2df4dd11cd086dc40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Vewdetails), @"mvc.1.0.view", @"/Controllers/Vewdetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3aff6cc48c9c7ddab97e8c2df4dd11cd086dc40", @"/Controllers/Vewdetails.cshtml")]
    public class Controllers_Vewdetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Farmers_Training.Models.Training>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>View Details of the training</h2>\r\n\r\n<div>\r\n    <h4>Farmers Training</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayFor(model => model.TrainerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayNameFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 37 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 41 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 45 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayFor(model => model.TrainingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 52 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 59 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n    ");
#nullable restore
#line 60 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Controllers\Vewdetails.cshtml"
Write(Html.ActionLink("Apply", "Create", "TrainingApplications"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Online_Farmers_Training.Models.Training> Html { get; private set; }
    }
}
#pragma warning restore 1591