#pragma checksum "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf38a5a014533728c6b3f3738dd68d84aa836b1"
// <auto-generated/>
#pragma warning disable 1591
namespace KnowledgeBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using KnowledgeBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\_Imports.razor"
using KnowledgeBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<KnowledgeBlazorApp.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<KnowledgeBlazorApp.Pages.Counter>(4);
            __builder.AddAttribute(5, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Project\WEB-315Assignment\KnowledgeBlazorApp\Pages\Index.razor"
                          1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
