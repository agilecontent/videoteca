using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videoteca.Models
{
    public class MovieRepository:NHibernateRepository<Movie>, IMovieRepository
    {
    }
}
