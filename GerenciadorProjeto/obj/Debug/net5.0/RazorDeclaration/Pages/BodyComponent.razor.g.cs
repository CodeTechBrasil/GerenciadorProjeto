// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
