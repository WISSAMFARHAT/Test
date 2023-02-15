using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.IO;

namespace Test.Components
{
    public partial class Page
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

        private async Task Test1()
        {
            await JR.InvokeVoidAsync("test1");
        }
    }
}