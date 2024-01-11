// See https://aka.ms/new-console-template for more information
using assignment5;


MovieManager movieManager = new MovieManager();

        Console.WriteLine("List of all movies:");
        List<Movie> allMovies = movieManager.GetAllMovies();
        PrintMovies(allMovies);

        Console.WriteLine("\nEnter the title to get a specific movie:");
        string title = Console.ReadLine();
        Movie specificMovie = movieManager.GetMovieByTitle(title);

        if (specificMovie != null)
        {
            Console.WriteLine($"\nDetails of movie '{title}':");
            PrintMovie(specificMovie);
        }
        else
        {
            Console.WriteLine($"Movie with title '{title}' not found.");
        }
    

    static void PrintMovies(List<Movie> movies)
    {
        foreach (var movie in movies)
        {
            PrintMovie(movie);
        }
    }

    static void PrintMovie(Movie movie)
    {
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine($"Year: {movie.Year}");
        Console.WriteLine();
    }
