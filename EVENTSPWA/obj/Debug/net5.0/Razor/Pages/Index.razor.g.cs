#pragma checksum "C:\Project\WEB-315Assignment\EVENTSPWA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6afa50dcaa8f58c70ece03b553c0eeaf3c07f69"
// <auto-generated/>
#pragma warning disable 1591
namespace EVENTSPWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using EVENTSPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\WEB-315Assignment\EVENTSPWA\_Imports.razor"
using EVENTSPWA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Harry!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<EVENTSPWA.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<p>login</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591