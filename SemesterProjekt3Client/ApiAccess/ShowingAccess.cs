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
    }
}
