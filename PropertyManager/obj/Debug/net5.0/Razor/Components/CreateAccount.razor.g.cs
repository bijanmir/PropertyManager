#pragma checksum "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\Components\CreateAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbc776d2184689227284da89689fa9d76e94f5a"
// <auto-generated/>
#pragma warning disable 1591
namespace PropertyManager.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using PropertyManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using PropertyManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bibia\RiderProjects\PropertyManager\PropertyManager\_Imports.razor"
using PropertyManager.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create-user")]
    public partial class CreateAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container login-area""><div class=""title-area""><h2>Create Account</h2>
        <subtitle>Create a new account</subtitle></div>
    

    <div class=""form-row""><div class=""row""><div class=""col-6 fname""><input type=""text"" class=""form-control"" placeholder=""First Name""></div>
            <div class=""col-6 lname""><input type=""text"" class=""form-control"" placeholder=""Last Name""></div></div>
        <div class=""row""><input type=""text"" class=""form-control"" placeholder=""📧 Email"">
            <input type=""text"" class=""form-control"" placeholder=""📱  Phone"">
            <input type=""password"" class=""form-control"" placeholder=""🔒 Password"">
            <input type=""password"" class=""form-control"" placeholder=""🔒 Password""></div>
        <button type=""submit"" class=""btn login-btn"">CREATE ACCOUNT</button>
         <div class=""subtitle-container""><p class=""subtitle-login"">Already have an account? <a href=""/"">Login</a></p></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
