using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Videoteca.Models.Mapping
{
    public class MovieMap:ClassMap<Movie>
    {
        public MovieMap()
        {
            Table("MOVIES");

            Id(x => x.Id);
            Map(x => x.Rating);
            Map(x => x.Title);
            Map(x => x.Year);

            References(x => x.Genre).LazyLoad(Laziness.False);
        }
    }
}