using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Videoteca.Models.Mapping
{
    public class GenreMap:ClassMap<Genre>
    {
        public GenreMap()
        {
            Table("GENRES");

            Id(x => x.Id);
            Map(x => x.Title);
            HasMany(x => x.Movies).Inverse().Cascade.All();
        }
    }
}