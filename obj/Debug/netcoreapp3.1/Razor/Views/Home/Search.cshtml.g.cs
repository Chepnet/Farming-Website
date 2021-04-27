#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e97f63e05f46f956c26610c6580699d73177f309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#nullable restore
#line 1 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97f63e05f46f956c26610c6580699d73177f309", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a350381296eab9b18303147657baccf3f41347", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Farmers_Training.Models.Training>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
  
    ViewBag.Title = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"alert-info\" style=\"color:green\">Search</h2>\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
 using (Html.BeginForm("Search", "Home", FormMethod.Get))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> Search Option: </b>");
#nullable restore
#line 20 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                      Write(Html.RadioButton("option", "Event"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Event");
#nullable restore
#line 20 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                                                                               Write(Html.RadioButton("option", "TrainerName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TrainerName ");
#nullable restore
#line 21 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
Write(Html.RadioButton("option", "TrainingTime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("TrainingTime");
#nullable restore
#line 21 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                                                                    Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" name=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 24 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
Write(Html.ActionLink("Event List", "Trainings", "Home"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                                                       

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\"\r\n       border=\"1\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
       Write(Html.ActionLink("EventName", "Search", new
       {
           sort = ViewBag.SortByEventName,
           option = @Context.Request.Query["option"],
           search = @Context.Request.Query["search"]
       }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th> ");
#nullable restore
#line 38 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
        Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n        <th>\r\n            ");
#nullable restore
#line 40 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
       Write(Html.ActionLink("TrainerName", "Search", new
            {
                sort = ViewBag.SortByTrainerName,
                option = @Context.Request.Query["option"],
                search = @Context.Request.Query["search"]
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n\r\n\r\n        <th> ");
#nullable restore
#line 50 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
        Write(Html.DisplayNameFor(model => model.TrainingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n        <th>\r\n            ");
#nullable restore
#line 52 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
       Write(Html.ActionLink("Cost", "Search", new
            {
                sort = ViewBag.SortByTrainerNa,
                option = @Context.Request.Query["option"],
                search = @Context.Request.Query["search"]
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"3\"> Records not found</td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
    }
    else
    {

        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 74 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                Write(Html.DisplayFor(modelItem => item.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 75 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.TrainerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td> ");
#nullable restore
#line 80 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                Write(Html.DisplayFor(modelItem => item.TrainingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td> ");
#nullable restore
#line 84 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"
                Write(Html.ActionLink(" View Details", "Viewdetails", "Home", new { id = item.TrainingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\LabStudent-55-504266\source\repos\Online Farmers Training\Views\Home\Search.cshtml"

        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online_Farmers_Training.Models.Training>> Html { get; private set; }
    }
}
#pragma warning restore 1591
