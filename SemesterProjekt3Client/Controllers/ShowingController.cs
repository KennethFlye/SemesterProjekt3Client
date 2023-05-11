using SemesterProjekt3Client.ApiAccess;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.Controllers
{
    public class ShowingController
    {
        ShowingAccess api;

        
       public ShowingController()
        {
            api = new ShowingAccess();
        }

        public async Task<bool> CreateShowing(Showing show)
        {
            bool saved;
            try
            {
                saved = await api.CreateShowing(show);
            }
            catch (Exception)
            {
                saved = false;
            }

            return saved;
        }

        public async Task<IEnumerable<Showing>> GetShowings()
        {
            IEnumerable<Showing> showings;

            try
            {
                showings = await api.GetShowings();
            }
            catch (Exception)
            {
                showings = null;
            }

            return showings;
        }
        public async Task<Showing> GetShowingById(int id)
        {
            Showing show;

            try
            {
                show = await api.GetShowingById(id);
            }
            catch (Exception)
            {
                show = null;
            }
            return show;
        }

        public async Task<bool> UpdateShowing(int id)
        {
            throw new NotImplementedException();
        }

    }
}
