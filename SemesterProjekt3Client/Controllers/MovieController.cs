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

        public async Task<bool> AddMovieInfoAsync(MovieInfo movie)
        {
            bool savedOk = await mAccess.AddMovieInfo(movie);
            return savedOk;
        }

        public async Task<bool> AddMovieCopyAsync(MovieCopy movieCopy)
        {
            bool savedOk = await mAccess.AddMovieCopy(movieCopy);
            return savedOk;
        }

        public async Task<bool> UpdateMovieInfoAsync(MovieInfo movieInfo)
        {
            bool updated = await mAccess.UpdateMovieInfo(movieInfo);
            return updated;
        }

        public async Task<bool> UpdateMovieCopyAsync(MovieCopy movieCopy)
        {
            bool updated = await mAccess.UpdateMovieCopy(movieCopy);
            return updated;
        }

        public async Task<IEnumerable<MovieInfo>> GetAllMovieInfosAsync() {
            IEnumerable<MovieInfo> movies = await mAccess.GetAllMovieInfos();
            return movies;
        }

        public async Task<IEnumerable<MovieCopy>> GetAllMovieCopiesAsync()
        {
            IEnumerable<MovieCopy> moviesCopies = await mAccess.GetAllMovieCopies();
            return moviesCopies;
        }

    }
}
