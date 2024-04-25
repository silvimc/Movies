using Movie.API.Dto;

namespace Movie.API.Services
{
    public interface IMovieService
    {
        List<Models.Movie> GetAllMovies();
        Models.Movie GetMovieById(int id);
        Models.Movie AddMovie(PostMovieDto Movie);
        Models.Movie UpdateMovie(PutMovieDto MovieData, int id);
        void DeleteMovie(int id);
    }
}
