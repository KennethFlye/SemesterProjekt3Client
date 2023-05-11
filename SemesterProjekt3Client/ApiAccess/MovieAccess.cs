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

        public async Task<bool> AddMovieInfo(MovieInfo movie)
        {
            bool savedOk = false;
            Uri uri = new Uri(baseUrl);

            try
            {
                var json = JsonConvert.SerializeObject(movie);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var postResponse = await client.PostAsync(uri, content);
                Console.WriteLine(postResponse.StatusCode);

                if (postResponse != null && postResponse.IsSuccessStatusCode)
                {
                    savedOk = true;
                }
            }
            catch
            {
                savedOk = false;
            }
            Console.WriteLine(savedOk);
            return savedOk;
        }

        public async Task<IEnumerable<MovieInfo>> GetAllMovieInfos()
        {
            List<MovieInfo> movieInfos;


            string url = baseUrl + $"/infos";
            var uri = new Uri(string.Format(url));


            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    movieInfos = JsonConvert.DeserializeObject<List<MovieInfo>>(content);
                }
                else
                {
                    movieInfos = null;
                }
            }
            catch
            {
                throw;
            }
            return movieInfos;
        }
    }
}
