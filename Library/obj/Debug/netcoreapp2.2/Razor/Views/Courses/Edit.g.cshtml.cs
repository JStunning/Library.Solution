#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f9c96944f5c7ccbe50cbe9bec47d15ab6a4ce56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Edit), @"mvc.1.0.view", @"/Views/Courses/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Edit.cshtml", typeof(AspNetCore.Views_Courses_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9c96944f5c7ccbe50cbe9bec47d15ab6a4ce56", @"/Views/Courses/Edit.cshtml")]
    public class Views_Courses_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 39, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this task: ");
            EndContext();
            BeginContext(114, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
               Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(156, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(200, 39, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.HiddenFor(model => model.CourseId));

#line default
#line hidden
            EndContext();
            BeginContext(248, 40, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.LabelFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(295, 41, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.EditorFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(345, 28, false);
#line 18 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.Label("Select student"));

#line default
#line hidden
            EndContext();
            BeginContext(380, 30, false);
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.DropDownList("StudentId"));

#line default
#line hidden
            EndContext();
            BeginContext(414, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(459, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(465, 40, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(505, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591