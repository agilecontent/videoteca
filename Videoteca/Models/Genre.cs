using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videoteca.Models
{
    public class Genre
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual IList<Movie> Movies { get; set; }

        public Genre()
        {
            this.Movies = new List<Movie>();
        }
    }
}