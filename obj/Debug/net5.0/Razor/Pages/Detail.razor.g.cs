#pragma checksum "C:\Frontend\blazorUas_72190277\Pages\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b116cfa623c26248ab5e9a49834868647e5e4f2e"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorUas_72190277.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using blazorUas_72190277;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Frontend\blazorUas_72190277\_Imports.razor"
using blazorUas_72190277.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailSt/{id}")]
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
 if (Student == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 6 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h2>Details</h2>\r\n");
            __builder.AddMarkupContent(2, "<h5>Student</h5>\r\n<hr>\r\n");
            __builder.OpenElement(3, "p");
            __builder.AddMarkupContent(4, "<b>Nim</b><span class=\"tab4\"></span> ");
            __builder.AddContent(5, 
#nullable restore
#line 13 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
                                         Student.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddMarkupContent(8, "<b>Nama Depan</b> <span class=\"tab3\"></span>");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
                                                Student.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "<b>Nama Belakang</b> <span class=\"tab\"></span> ");
            __builder.AddContent(13, 
#nullable restore
#line 15 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
                                                   Student.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "<b>Tanggal Masuk </b><span class=\"tab\"></span> ");
            __builder.AddContent(17, 
#nullable restore
#line 16 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
                                                   Student.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<hr>");
            __builder.OpenElement(19, "table");
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 22 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"
                        $"editSt/{Student.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn btn-outline-warning");
            __builder.AddContent(26, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, "<a href=\"/studentpage\" type=\"button\" class=\"btn btn-outline-primary\">Back To List</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Frontend\blazorUas_72190277\Pages\Detail.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
