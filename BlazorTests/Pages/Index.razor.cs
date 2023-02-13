using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorTests;
using BlazorTests.Shared;

namespace BlazorTests.Pages
{
    public partial class Index
    {
        public string Name { get; set; } = "Next";
        public int Count { get; set; } = 0;
        private async Task Next()
        {
            //NM.NavigateTo("/test");
            Count++;
            Name = "back";
            this.StateHasChanged();

            return;
        }

        private async Task Test()
        {
            await JR.InvokeVoidAsync("test");
        }
    }
}