#pragma checksum "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed9e049d9d4f1187c27c249dcb4b823fff92ab1"
// <auto-generated/>
#pragma warning disable 1591
namespace GerenciadorProjeto.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using GerenciadorProjeto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\_Imports.razor"
using GerenciadorProjeto.Shared;

#line default
#line hidden
#nullable disable
    public partial class BodyComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor"
                  CarregarLista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Carregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n      ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row col-12");
#nullable restore
#line 6 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor"
 foreach (var item in projetos)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3 p-1");
            __builder.AddAttribute(8, "style", "\r\n    vertical-align:middle;\r\n    height: 200px;\r\n    width: 200px;\r\n    margin:10px;\r\n    margin-top: 11px;\r\n    border-radius: 0px 31px 0px 26px;\r\n    background-color: white;\r\n    box-shadow: 0 0 1em #7e7d76;\r\n");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "style", "text-align:center;    margin-top: 32%; padding:10px;");
#nullable restore
#line 18 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor"
__builder.AddContent(11, item);

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, " uitr");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor"
    
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n<div class=\"card-project\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\_LAB\Web\GerenciadorProjeto\GerenciadorProjeto\Pages\BodyComponent.razor"
       
    List<string> projetos = new List<string>();
        
    protected override void OnInitialized()
    {
        projetos.Add("CARTOGRAFIA");
        projetos.Add("DESENVOLVIMENTO");
        projetos.Add("SUPORTE");
        projetos.Add("4");
        projetos.Add("5");
        projetos.Add("6");
        projetos.Add("7");
        projetos.Add("8");
        projetos.Add("9");
      
    }

    public void CarregarLista()
    {
        projetos.Clear();
    }

    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
