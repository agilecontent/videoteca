using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Videoteca.Models
{
    public class NHibernateRepository<T>:IRepository<T> where T:class
    {
        public ISession OpenSession()
        {
            var sessionFactory = CreateSessionFactory();
            return sessionFactory.OpenSession();
        }
        private static ISessionFactory CreateSessionFactory()
        {
            var config = Fluently.Configure();
            config.Database(MsSqlConfiguration.MsSql2005.ConnectionString(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Videoteca.mdf;Integrated Security=True;User Instance=True"));
            config.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Videoteca.MvcApplication>());
            return config.BuildSessionFactory();
        }

        #region IRepository<T> Members

        public IEnumerable<T> FindAll()
        {
            using (var session = this.OpenSession())
            {
                return session.CreateCriteria<T>().List<T>();
            }
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(T model)
        {
            throw new NotImplementedException();
        }

        public void Remove(T model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}