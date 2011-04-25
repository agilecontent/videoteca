using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoteca.Models;

namespace Videoteca.Models
{
    public class DataContext:IDataContext
    {
        public IGenreRepository Genres
        {
            get
            {
                return new GenreRepository();
            }
        }
        public IMovieRepository Movies
        {
            get
            {
                return new MovieRepository();
            }
        }
    }
}