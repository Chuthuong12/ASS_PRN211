#pragma checksum "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72dcd60786dd09d9359832506aa2a4daeb9d81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72dcd60786dd09d9359832506aa2a4daeb9d81c", @"/Areas/Admin/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Testing.Models.Sanpham>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Xoá vĩnh viễn sản phẩm</h2>\r\n\r\n\r\n<div>\r\n    <h4>Sản phẩm</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Hãng sản phẩm\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hangsanxuat.Tenhang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Hệ điều hành\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hedieuhanh.Tenhdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Tên sản phẩm\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Giá tiền\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 43 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Giatien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Số lượng\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 51 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Mô tả sản phẩm\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Thẻ sim\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 67 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thesim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Bộ nhớ trong\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 75 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bonhotrong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Bộ nhớ RAM\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 83 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Sản phẩm mới\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 91 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sanphammoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Ảnh sản phẩm\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 99 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Anhbia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 104 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-warning\"/> |\r\n            ");
#nullable restore
#line 110 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
       Write(Html.ActionLink("Về trang chủ", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 112 "C:\Users\thuong\Downloads\ProjectPRN2112\ProjectPRN211\ProjectPRN211\Areas\Admin\Views\Home\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    \r\n\r\n");
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
