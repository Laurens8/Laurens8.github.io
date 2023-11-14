using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Geboortedatum
    {
        public ElementReference resultElement;
        public string resultText = "";
        public string resultText2 = "";
        public string resultText3 = "";
        public string resultText4 = "";
        public DateTime? birthdate { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await FunFact();
        }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public async Task FunFact()
        {
            var birthdateString = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "gbdate");
            if (DateTime.TryParse(birthdateString, out var birthdate))
            {
                var now = DateTime.Now;

                await JSRuntime.InvokeVoidAsync("localStorage.removeItem", "gbdate");

                var gbdag = birthdate.ToString("dddd, d MMMM yyyy", new CultureInfo("nl-BE"));
                resultText = "Vandaag is het " + now.ToString("dddd, d MMMM yyyy", new CultureInfo("nl-BE"));
                resultText2 = "Je bent geboren op " + gbdag;

                var diffInTime = now - birthdate;
                var diffInDays = (int)diffInTime.TotalDays;
                resultText3 = "Je loopt al " + diffInDays + " dagen op deze wereldbol rond.";

                const double gemJaren = 80.3;
                var totDagen = (int)(365 * gemJaren);
                var nogTeLevenDagen = totDagen - diffInDays;
                var teLeven = now + TimeSpan.FromDays(nogTeLevenDagen);
                resultText4 = "Je zal vermoedelijk sterven op " + teLeven.ToString("dddd, d MMMM yyyy", new CultureInfo("nl-BE"));
            }
        }

        public void GoBack()
        {
            NavigationManager.NavigateTo("FunFacts");
        }
    }
}
