#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559cf5aa7a5ae55ed4a244cf0af833452f9d54e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrons_Details), @"mvc.1.0.view", @"/Views/Patrons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patrons/Details.cshtml", typeof(AspNetCore.Views_Patrons_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559cf5aa7a5ae55ed4a244cf0af833452f9d54e0", @"/Views/Patrons/Details.cshtml")]
    public class Views_Patrons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 39, true);
            WriteLiteral("\r\n<h2>Patron Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(103, 16, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(119, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
 if(@Model.Copys.Count == 0)
{

#line default
#line hidden
            BeginContext(161, 59, true);
            WriteLiteral("  <p>This Patron hasn\'t checked out any of our books.</p>\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(232, 45, true);
            WriteLiteral("  <h4>Copies they checked out:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
   foreach(var join in Model.Copys)
  { 

#line default
#line hidden
            BeginContext(320, 36, true);
            WriteLiteral("    <li id=\"mark\">\r\n      <p>Title: ");
            EndContext();
            BeginContext(357, 90, false);
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
           Write(Html.ActionLink($"{ join.Copy.Books }", "Details", "Books", new { id = join.Copy.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(447, 28, true);
            WriteLiteral("</p>\r\n      <p>Copy Number: ");
            EndContext();
            BeginContext(476, 62, false);
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
                 Write(Html.ActionLink($"{ join.Copy.CopyNumber }", "Index", "Copys"));

#line default
#line hidden
            EndContext();
            BeginContext(538, 25, true);
            WriteLiteral("</p>\r\n      <p>Due Date: ");
            EndContext();
            BeginContext(564, 21, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
              Write(join.Copy.CopyDueDate);

#line default
#line hidden
            EndContext();
            BeginContext(585, 17, true);
            WriteLiteral("</p>\r\n    </li>\r\n");
            EndContext();
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(607, 19, true);
            WriteLiteral("  </ul>\r\n  <hr />\r\n");
            EndContext();
#line 29 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
}

#line default
#line hidden
            BeginContext(629, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(635, 53, false);
#line 31 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
Write(Html.ActionLink("Add Book to list", "Index", "Copys"));

#line default
#line hidden
            EndContext();
            BeginContext(688, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(698, 43, false);
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
Write(Html.ActionLink("Back to Patrons", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(741, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(751, 67, false);
#line 33 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
Write(Html.ActionLink("Edit Patron", "Edit", new { id = Model.PatronId }));

#line default
#line hidden
            EndContext();
            BeginContext(818, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(828, 71, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Patrons\Details.cshtml"
Write(Html.ActionLink("Delete Patron", "Delete", new { id = Model.PatronId }));

#line default
#line hidden
            EndContext();
            BeginContext(899, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Patron> Html { get; private set; }
    }
}
#pragma warning restore 1591
