#pragma checksum "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22279f312e604ea1e89092cbc90d6563e0e08ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\brandnew - backup\brandnew\testcsharp\Views\_ViewImports.cshtml"
using testcsharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\brandnew - backup\brandnew\testcsharp\Views\_ViewImports.cshtml"
using testcsharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22279f312e604ea1e89092cbc90d6563e0e08ffc", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c212b555005bf2ac7a90e02a43036eead3c0fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<testcsharp.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
  

    ViewData["Title"] = "Testing!";
    String[] teammember = new String[] { "Mohammad", "Louis", "Anni", "Alex", "Oli", "Nadi" };
    int[] ages = new int[] { 0, 23, 23, 0, 0, 23 };

    var louis = new Student();
    louis.age = 23;
    louis.name = "Louis";

    var anni = new Student_with_attributes("Anni", 23);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 16 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
 for (var i = 0; i < teammember.Length; i++)
{
    var person = teammember[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n    <text>Name: ");
#nullable restore
#line 24 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
           Write(person);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n</p>\r\n");
#nullable restore
#line 26 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
  
    int j = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
 while (j < teammember.Length)
{
    var person = ages[j];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 35 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
  Write(teammember[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ist ");
#nullable restore
#line 35 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
                     Write(ages[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Jahre alt</p>\r\n");
#nullable restore
#line 36 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"

    j++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
  
    var babys = 0;
    foreach (int element in ages)
    {
        if (element < 25)
        {
            babys++;
        }
    }
    var adults = teammember.Length - babys;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>We have ");
#nullable restore
#line 51 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
           Write(babys);

#line default
#line hidden
#nullable disable
            WriteLiteral(" babys and ");
#nullable restore
#line 51 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
                            Write(adults);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adults.</h2>\r\n");
            WriteLiteral("<br />\r\n\r\n");
            WriteLiteral("    <p>");
#nullable restore
#line 57 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
  Write(louis.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ist ");
#nullable restore
#line 57 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
                  Write(louis.age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" alt.</p>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    <p> ");
#nullable restore
#line 62 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
   Write(anni.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ist ");
#nullable restore
#line 62 "D:\brandnew - backup\brandnew\testcsharp\Views\Home\Privacy.cshtml"
                  Write(anni.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" alt. </p>\r\n");
            WriteLiteral("\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<testcsharp.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
