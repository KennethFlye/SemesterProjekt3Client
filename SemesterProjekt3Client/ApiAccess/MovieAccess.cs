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
            string url = baseUrl + $"/infos";
            Uri uri = new Uri(string.Format(url));

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

        public async Task<bool> AddMovieCopy(MovieCopy movieCopy)
        {
            bool savedOk = false;
            string url = baseUrl + $"/copies";
            Uri uri = new Uri(string.Format(url));

            try
            {
                var json = JsonConvert.SerializeObject(movieCopy);
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

        public async Task<bool> UpdateMovieInfo(MovieInfo movieInfo)
        {
            bool updated = false;
            string url = baseUrl + $"/infos";
            Uri uri = new Uri(string.Format(url));

            try
            {
                var json = JsonConvert.SerializeObject(movieInfo);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var patchResponse = await client.PatchAsync(uri, content);
                Console.WriteLine(patchResponse.StatusCode);

                if (patchResponse != null && patchResponse.IsSuccessStatusCode)
                {
                    updated = true;
                }
            }
            catch
            {
                updated = false;
            }
            Console.WriteLine(updated);
            return updated;
        }

        public async Task<bool> UpdateMovieCopy(MovieCopy movieCopy)
        {
            bool updated = false;
            string url = baseUrl + $"/copies";
            Uri uri = new Uri(string.Format(url));

            try
            {
                var json = JsonConvert.SerializeObject(movieCopy);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var patchResponse = await client.PatchAsync(uri, content);
                Console.WriteLine(patchResponse.StatusCode);

                if (patchResponse != null && patchResponse.IsSuccessStatusCode)
                {
                    updated = true;
                }
            }
            catch
            {
                updated = false;
            }
            Console.WriteLine(updated);
            return updated;
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

        public async Task<IEnumerable<MovieCopy>> GetAllMovieCopies()
        {
            List<MovieCopy> movieCopies;


            string url = baseUrl;
            var uri = new Uri(string.Format(url));


            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    movieCopies = JsonConvert.DeserializeObject<List<MovieCopy>>(content);
                }
                else
                {
                    movieCopies = null;
                }
            }
            catch
            {
                throw;
            }
            return movieCopies;
        }

        public async Task<MovieCopy> GetShowingById(int id)
        {
            MovieCopy copy;
            string url = baseUrl + $"/{id}";
            var uri = new Uri(string.Format(url));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    copy = JsonConvert.DeserializeObject<MovieCopy>(content);
                }
                else
                {
                    copy = null;
                }
            }
            catch
            {
                throw;
            }
            return copy;
        }
    }
}
