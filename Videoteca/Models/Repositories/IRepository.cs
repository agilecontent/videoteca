using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videoteca.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> FindAll();
        T FindById(int id);
        void Save(T model);
        void Remove(T model);
    }
}
