using Newtonsoft.Json;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.ApiAccess
{
    public class MovieAccess
    {
        readonly string baseUrl = "https://localhost:7155/api/movies";
        readonly HttpClient client;

        public MovieAccess()
        {
            client = new HttpClient();
        }

        public async Task<IEnumerable<MovieCopy>> GetMoviesCopies()
        {
            List<MovieCopy> movies;

            var uri = new Uri(baseUrl);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    movies = JsonConvert.DeserializeObject<List<MovieCopy>>(content);
                }
                else
                {
                    movies = null;
                }
            }
            catch
            {
                throw;
            }
            return movies;
        }
    }
}
