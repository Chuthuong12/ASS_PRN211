#pragma checksum "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6619c46783a09dab20bbae0f0550c07fb94aa9a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6619c46783a09dab20bbae0f0550c07fb94aa9a4", @"/Areas/Admin/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Testing.Models.Sanpham>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Chỉnh sửa sản phẩm</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n      \r\n            <hr />\r\n            ");
#nullable restore
#line 16 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Masp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                Tên sản phẩm\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Tensp, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Tensp, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Giá tiền\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Giatien, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Giatien, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Số lượng\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Soluong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Soluong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Mô tả\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Mota, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mota, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Thẻ sim\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Thesim, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Thesim, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Bộ nhớ trong\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Bonhotrong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Bonhotrong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Sản phẩm mới\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Sanphammoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 72 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Sanphammoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Bộ nhớ RAM\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Ram, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 81 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ram, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Ảnh bìa\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.Anhbia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 89 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Anhbia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Chọn hãng \r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 96 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.DropDownList("Mahang", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 97 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mahang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                Chọn hệ điều hành\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 104 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.DropDownList("Mahdh", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 105 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mahdh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Save"" class=""btn btn-success"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 115 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 118 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Edit.cshtml"
   Write(Html.ActionLink("Về trang chủ", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Testing.Models.Sanpham> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
