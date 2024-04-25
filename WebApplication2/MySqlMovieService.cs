using Movie.API.Dto;

namespace Movie.API.Services
{
    public class MySqlMovieService : IMovieService
    {
        public Models.Movie AddMovie(PostMovieDto Movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<Models.Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Models.Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Movie UpdateMovie(PutMovieDto MovieData, int id)
        {
            throw new NotImplementedException();
        }
    }
}
