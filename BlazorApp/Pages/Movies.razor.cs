using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Movies
    {
        private string searchTerm;
        private List<Movie> movies = new List<Movie>();
        private string message = "";
        private HttpClient httpClient = new HttpClient();

        protected override void OnInitialized()
        {
            httpClient = new HttpClient();
        }

        private async Task Search()
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                message = "Deze zoekopdracht is te kort (2-15 tekens toegelaten)";
                return;
            }

            if (searchTerm.Length > 15)
            {
                message = "Deze zoekopdracht is te lang (2-15 tekens toegelaten)";
                return;
            }

            var response = await httpClient.GetFromJsonAsync<OMDBResponse>($"https://www.omdbapi.com/?s={searchTerm}&type=movie&apikey=75867c06");

            if (response.Response == "True")
            {
                movies = response.Search;
                message = $"Aantal gevonden: {response.totalResults}";
            }
            else
            {
                message = response.Error;
                movies.Clear();
            }
        }

        private class Movie
        {
            public string Poster { get; set; }
            public string Title { get; set; }
            public string Year { get; set; }
        }

        private class OMDBResponse
        {
            public string Response { get; set; }
            public List<Movie> Search { get; set; }
            public string totalResults { get; set; }
            public string Error { get; set; }
        }
    }
}
