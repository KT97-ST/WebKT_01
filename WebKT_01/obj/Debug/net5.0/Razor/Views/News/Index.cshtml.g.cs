#pragma checksum "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc78e75be661fb70d4ef1452f3a84941ec087894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\_ViewImports.cshtml"
using WebKT_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\_ViewImports.cshtml"
using WebKT_01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc78e75be661fb70d4ef1452f3a84941ec087894", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9dcd1a12e2e4faa49afe358377d9db133e06d05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebKT_01.Controllers.Aricle>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
  
    ViewData["Title"] = "New Pages";
    Layout = "_Layout";

    //var articles = ViewBag.Article;
    //var articles = ViewData["Articles"] as List<WebKT_01.Controllers.Aricle>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <h1>New Listing</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Title</th>\r\n        <th>Content</th>\r\n        <th>Author</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
     foreach (var article in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
           Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
           Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
           Write(article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
           Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\Coding\CShapes\ASP_NetCore\WebKT_01\WebKT_01\Views\News\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebKT_01.Controllers.Aricle>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
