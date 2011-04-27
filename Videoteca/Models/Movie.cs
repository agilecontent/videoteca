using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videoteca.Models
{
    public class Movie
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual int Year { get; set; }
        public virtual int Rating { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual int GenreId { get; set; }
    }
}