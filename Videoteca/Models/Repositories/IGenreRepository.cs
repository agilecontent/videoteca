using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Videoteca.Models
{
    public interface IGenreRepository:IRepository<Genre>
    {
        IEnumerable<Genre> AllByTitle();
    }
}
