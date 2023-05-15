using Newtonsoft.Json;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.ApiAccess
{
    public class ShowingAccess
    {
        readonly string baseUrl = "https://localhost:7155/api/showings";
        readonly HttpClient client;

        public ShowingAccess()
        {
            client = new HttpClient();
        }

        public async Task<bool> CreateShowing(Showing show)
        {
            bool savedOk = false;
            var uri = new Uri(baseUrl);

            try
            {
                var json = JsonConvert.SerializeObject(show);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var postResponse = await client.PostAsync(uri, content);
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
        public async Task<IEnumerable<Showing>> GetShowingsAsync()
        {
            List<Showing> show;
            var uri = new Uri(baseUrl);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    show = JsonConvert.DeserializeObject<List<Showing>>(content);
                }
                else
                {
                    show = null;
                }
            }
            catch
            {
                throw;
            }
            return show;
        }
        public async Task<Showing> GetShowingById(int id)
        {
            Showing show;
            string url = baseUrl + $"/{id}";
            var uri = new Uri(string.Format(url));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    show = JsonConvert.DeserializeObject<Showing>(content);
                }
                else
                {
                    show = null;
                }
            }
            catch
            {
                throw;
            }
            return show;
        }

        public async Task<bool> UpdateShowing(int id, Showing showing)
        {
            string url = baseUrl + $"/{id}";
            Uri uri = new Uri(string.Format(url));

            showing.ShowRoom.Seats = new();
            try
            {
                var json = JsonConvert.SerializeObject(showing);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                MessageBox.Show(await content.ReadAsStringAsync()); //Hvis denne mangler dør koden...
                var patchResponse = await client.PutAsync(uri,content);

                if (patchResponse != null && patchResponse.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch 
            {

            }
            return false;
        }


    }
}