using SemesterProjekt3Client.ApiAccess;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.Controllers
{
    public class ShowRoomController
    {
        ShowRoomAccess rAccess;

        public ShowRoomController()
        {
            rAccess = new ShowRoomAccess();
        }
        public async Task<IEnumerable<ShowRoom>> GetShowRooms()
        {
            IEnumerable<ShowRoom> rooms;

                rooms = await rAccess.GetShowRooms();
           
            return rooms;
        }
    }
}
