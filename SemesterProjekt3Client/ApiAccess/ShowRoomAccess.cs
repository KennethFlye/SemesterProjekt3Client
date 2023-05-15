using Newtonsoft.Json;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.ApiAccess
{
    public class ShowRoomAccess
    {
        readonly string baseUrl = "https://localhost:7155/api/showrooms";
        readonly HttpClient client;

        public ShowRoomAccess()
        {
            client = new HttpClient();
        }

        public async Task<IEnumerable<ShowRoom>> GetShowRooms()
        {
            List<ShowRoom> rooms;

            var uri = new Uri(baseUrl);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    rooms = JsonConvert.DeserializeObject<List<ShowRoom>>(content);
                }
                else
                {
                    rooms = null;
                }
            }
            catch
            {
                throw;
            }
            return rooms;
        }
    }
}
