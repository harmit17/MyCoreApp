#pragma checksum "G:\Centennial\Semester 4\DevOps\Assignment 1\MyCoreApp\MyCoreApp\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a5b3b02143d0f6d00d57ed4aa9daa3661e68b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyCoreApp.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace MyCoreApp.Pages
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
#line 1 "G:\Centennial\Semester 4\DevOps\Assignment 1\MyCoreApp\MyCoreApp\Pages\_ViewImports.cshtml"
using MyCoreApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a5b3b02143d0f6d00d57ed4aa9daa3661e68b1", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d08c9fd3ec0f6d6281bbd1e4a154616bed1c17a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "G:\Centennial\Semester 4\DevOps\Assignment 1\MyCoreApp\MyCoreApp\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "G:\Centennial\Semester 4\DevOps\Assignment 1\MyCoreApp\MyCoreApp\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>This page is under construction as of ");
#nullable restore
#line 8 "G:\Centennial\Semester 4\DevOps\Assignment 1\MyCoreApp\MyCoreApp\Pages\Privacy.cshtml"
                                    Write(ViewData["TimeStamp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<p>
    Privacy, in short, is the right to be free from interference or intrusion — the ability to be left alone without being watched. Information privacy refers to the right to have control over how your personal information and data are collected, stored, and used. Privacy policies are in place to protect sensitive information and safeguard your identity. Privacy is often about using sensitive information responsibly. Organizations are required to be transparent about what forms of data they intend to collect, the purpose of the data collection, and where and with whom it is to be shared. As the user, you have to accept these terms and conditions; therefore, you have the right to control your shared information.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
