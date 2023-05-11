using SemesterProjekt3Client.ApiAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.Controllers
{
    public class ShowingController
    {
        ShowingAccess sAccess;

        ShowingController()
        {
            sAccess = new ShowingAccess();
        }
    }
}
