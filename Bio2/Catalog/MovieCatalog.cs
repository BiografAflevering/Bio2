
using System.Collections.Generic;
using Windows.Security.Cryptography.Core;

namespace Bio2
{
    public class MovieCatalog 
    {
      

        private List<Movie> movies;

      

        public MovieCatalog()
        {
            movies = new List<Movie>();
            movies.Add(new Movie("Avatar", 150, "Assets\\b1.jpg"));
            movies.Add(new Movie("Venom", 145, "Assets\\b2.jpg"));
            movies.Add(new Movie("Spiderman",135, "Assets\\b3.jpg"));
            movies.Add(new Movie("Superman",130, "Assets\\b1.jpg"));
        }
        public List<Movie> Movies
        {
            get { return movies; }
        }


    }
    }
