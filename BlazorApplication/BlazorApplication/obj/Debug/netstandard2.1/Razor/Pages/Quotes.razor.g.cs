#pragma checksum "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a522ccd96abf046b671db2462eb26de531b36c1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quotes")]
    public partial class Quotes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "display-4");
            __builder.AddContent(2, 
#nullable restore
#line 8 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                       Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<style>\r\n    #myButton {\r\n        margin-bottom: 2.5em;\r\n    }\r\n\r\n    #navInputBox {\r\n        width: 28%;\r\n    }\r\n    .sort-th {\r\n        cursor: pointer;\r\n    }\r\n\r\n    .fa {\r\n        float: right;\r\n    }\r\n</style>");
#nullable restore
#line 26 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
 if (friend.listOfQuotes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner-border text-primary\" role=\"status\"><span class=\"visually-hidden\"></span></div>");
#nullable restore
#line 31 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                   Alert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "id", "myButton");
            __builder.AddContent(11, "Random Quote");
            __builder.CloseElement();
            __builder.OpenElement(12, "nav");
            __builder.AddAttribute(13, "class", "navbar navbar-light bg-light");
            __builder.AddAttribute(14, "id", "navInputBox");
            __builder.OpenElement(15, "form");
            __builder.AddAttribute(16, "class", "container-fluid");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "input-group");
            __builder.AddMarkupContent(19, @"<span class=""input-group-text"" id=""basic-addon1""><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person-fill"" viewBox=""0 0 16 16""><path fill-rule=""evenodd"" d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z""></path></svg></span>
                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Character or Keyword i.e Pivot");
            __builder.AddAttribute(24, "aria-label", "Character");
            __builder.AddAttribute(25, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                                                                                                                                   (e) => { friend.InputValue = (string)e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                                                                                                    friend.InputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => friend.InputValue = __value, friend.InputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table");
            __builder.OpenElement(31, "thead");
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "class", "sort-th");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                () => friend.SortTable("Character")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Character");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddMarkupContent(38, "<th>Quote</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n        ");
            __builder.OpenElement(40, "tbody");
#nullable restore
#line 60 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
             foreach (var item in friend.listOfQuotes.Where(x => friend.IsVisible(x)))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 63 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                         item.character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 64 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                         item.quote

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
       
    private bool isSortedAscending;
    private string activeSortColumn;

    private string Title = "Friends Quotes"; // Title data
    private Friends friend = new Friends 
    { 
        listOfQuotes = new List<Friends>()
    };

    private Friends randomQuote;
    public string Message
    {
        get
        {
            return $"{randomQuote.quote} ({randomQuote.character})";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        friend.listOfQuotes = await client.GetFromJsonAsync<List<Friends>>("https://friends-quotes-api.herokuapp.com/quotes");
        randomQuote = await client.GetFromJsonAsync<Friends>("https://friends-quotes-api.herokuapp.com/quotes/random");
    }

    private async Task Alert()
    {
        await JS.InvokeAsync<string>("Alert", Message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
