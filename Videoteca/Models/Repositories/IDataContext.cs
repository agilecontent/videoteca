using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videoteca.Models
{
    public interface IDataContext
    {
        IGenreRepository Genres { get; }
        IMovieRepository Movies { get; }
    }
}