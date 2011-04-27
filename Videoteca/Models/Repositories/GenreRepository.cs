using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Criterion;

namespace Videoteca.Models
{
    public class GenreRepository:NHibernateRepository<Genre>, IGenreRepository
    {
        public IEnumerable<Genre> AllByTitle()
        {
            using (var session = this.OpenSession())
            {
                return session.CreateCriteria<Genre>().AddOrder(Order.Asc("Title")).List<Genre>();
            }
        }
    }
}