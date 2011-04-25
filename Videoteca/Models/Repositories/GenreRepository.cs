using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Videoteca.Models
{
    public class GenreRepository:NHibernateRepository<Genre>, IGenreRepository
    {
    }
}