using Movie.API;
using Movie.API.Dto;

namespace Movie.API.Services
{
    public class MoviesService : IMovieService
    {
        private AppDbContext _context;
        public MoviesService(AppDbContext context)
        {
            _context = context;
        }


        public List<Models.Movie> GetAllMovies()
        {
            var allMovies = _context.Movies.ToList();
            return allMovies;
        }

        public Models.Movie AddMovie(PostMovieDto Movie)
        {
            var newMovie = new Models.Movie()
            {
                Title = Movie.Title,
                Director = Movie.Director,
            };

            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            return newMovie;
        }

        public void DeleteMovie(int id)
        {
            var MovieDb = _context.Movies
                .FirstOrDefault(n => n.Id == id);

            _context.Movies.Remove(MovieDb);
            _context.SaveChanges();
        }



        public Models.Movie GetMovieById(int id)
        {
            var newMovie = _context.Movies
                .FirstOrDefault(n => n.Id == id);

            return newMovie;
        }

        public Models.Movie UpdateMovie(PutMovieDto MovieData, int id)
        {
            var MovieDb = _context.Movies
                .FirstOrDefault(n => n.Id == id);

            MovieDb.Title = MovieData.Title;
            _context.Movies.Update(MovieDb);

            _context.SaveChanges();

            return MovieDb;
        }
    }
}