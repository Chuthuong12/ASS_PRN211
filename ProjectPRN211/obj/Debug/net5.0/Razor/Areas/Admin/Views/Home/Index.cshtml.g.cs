#pragma checksum "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae0d651a27fa75cf250aafd95ce9cb3ff0facaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 6 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
using Project_Testing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae0d651a27fa75cf250aafd95ce9cb3ff0facaf", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sanpham>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Quản lý sản phẩm </h2>\r\n\r\n<p>\r\n    <button class=\"btn-default\">");
#nullable restore
#line 12 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Thêm mới", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
</p>
<table class=""table table-bordered"">
    <tr>

        <th>
            Tên sản phẩm
        </th>
        <th>
            Giá tiền
        </th>
        <th>
            Số lượng
        </th>
        <th>
            Mô tả
        </th>
        <th>
            Thẻ sim
        </th>
        <th>
            Ảnh bìa
        </th>
        <th>
            Tên hãng
        </th>
        <th>
            Hệ điều hành
        </th>
        <th> Hành động</th>
    </tr>

");
#nullable restore
#line 44 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Giatien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Thesim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1353, "\"", 1400, 1);
#nullable restore
#line 64 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1359, Url.Content("~/HinhanhSP/" +item.Anhbia), 1359, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hangsanxuat.Tenhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hedieuhanh.Tenhdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Sửa", "Edit", new { id = item.Masp }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 75 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Chi tiết", "Details", new { id = item.Masp }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 76 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Xoá", "Delete", new { id = item.Masp }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sanpham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
