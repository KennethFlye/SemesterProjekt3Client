using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.ApiAccess
{
    public class BookingAccess
    {
        readonly string baseUrl = "https://localhost:7155/api/bookings";
        readonly HttpClient client;

        public BookingAccess()
        {
            client = new HttpClient();
        }
    }
}
