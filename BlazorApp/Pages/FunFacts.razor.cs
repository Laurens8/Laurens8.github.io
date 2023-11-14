using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorApp.Pages
{
    public partial class FunFacts
    {
        public ElementReference resultElement;
        public string resultText = "";
        public DateTime? birthdate { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private async Task SetBirthdate()
        {
            if (birthdate.HasValue)
            {
                await JSRuntime.InvokeVoidAsync("localStorage.setItem", "gbdate", birthdate.Value.ToString("s"));
                NavigationManager.NavigateTo("geboortedatum");
            }
        }
    }
}
