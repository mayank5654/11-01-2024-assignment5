using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class MovieManager
    {
        private List<Movie> movies;
        public MovieManager()
        {
            // Initialize the movies list
            movies = new List<Movie>
        {
            new Movie { Title = "hanuman", Director = "rudransh", Year = 2020 },
            new Movie { Title = "shiva", Director = "mahadeva", Year = 2021 },
            // Add more movies as needed
        };
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByTitle(string title)
        {
            return movies.FirstOrDefault(movie => movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}

