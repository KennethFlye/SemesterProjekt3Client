using SemesterProjekt3Client.ApiAccess;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt3Client.Controllers
{
    public class MovieController
    {
        MovieAccess mAccess;

        public MovieController()
        {
            mAccess = new MovieAccess();
        }
        public async Task<IEnumerable<MovieCopy>> GetMoviesCopy()
        {
            IEnumerable<MovieCopy> movies;

                movies = await mAccess.GetMoviesCopies();
            
        
            return movies;
        }
    }
}
