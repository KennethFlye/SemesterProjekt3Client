using SemesterProjekt3Client.ApiAccess;
using SemesterProjekt3Client.Model;

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
            

           bool saved = await api.CreateShowing(show);


            return saved;
        }

        public async Task<IEnumerable<Showing>> GetShowingsAsync()
        {
            IEnumerable<Showing> showings = await api.GetShowingsAsync();


           


            return showings;
        }
        public async Task<Showing> GetShowingById(int id)
        {
         
            Showing show = await api.GetShowingById(id);

            return show;
        }

        public async Task<bool> UpdateShowing(int id)
        {
            throw new NotImplementedException();
        }

    }
}
