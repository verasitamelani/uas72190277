#pragma checksum "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c0a204c59a74f945dc0c2603e78b46535bd077"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailenroll/{id}")]
    public partial class DetailEnroll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
 if (Enroll == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 6 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3> Show Enrollment </h3>\r\n");
            __builder.AddMarkupContent(2, "<a href type=\"button\" class=\"btn btn-outline-primary\">Create New</a><br><br>\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table bg-light");
            __builder.AddMarkupContent(5, "<thead class=\"thead-dark\"><tr><th>CourseID</th>\r\n            <th>Title </th>\r\n            <th>Credits </th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 20 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
         foreach (var en in Enroll)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 23 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
                 en.courseID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
                 en.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
                 en.credits

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
        } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Frontend\blazorUas_72190277\Pages\DetailEnroll.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591