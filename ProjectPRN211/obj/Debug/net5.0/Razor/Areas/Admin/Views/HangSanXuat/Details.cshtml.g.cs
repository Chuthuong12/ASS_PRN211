#pragma checksum "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2905f8f9f8d61edffabd924afeb7573086d54dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HangSanXuat_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/HangSanXuat/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2905f8f9f8d61edffabd924afeb7573086d54dd0", @"/Areas/Admin/Views/HangSanXuat/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_HangSanXuat_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Testing.Models.Hangsanxuat>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Details.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Hãng sản xuất</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Tên hãng\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tenhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 24 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Mahang }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 25 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Testing.Models.Hangsanxuat> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591