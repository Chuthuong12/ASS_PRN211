#pragma checksum "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d264809c6b7639d2f2ca4da8f16818cb0ece323e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HangSanXuat_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/HangSanXuat/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d264809c6b7639d2f2ca4da8f16818cb0ece323e", @"/Areas/Admin/Views/HangSanXuat/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_HangSanXuat_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Testing.Models.Hangsanxuat>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Hãng sản xuất</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 17 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            Tên hãng\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
           Write(Html.EditorFor(model => model.Tenhang, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tenhang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 35 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\HangSanXuat\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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