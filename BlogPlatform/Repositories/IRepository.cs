using BlogPlatform.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public interface IRepository<T> : ISelectList
    {
        //C
        void Create(T obj);
        //R
        IEnumerable<T> GetAll();
        T GetByID(int id);
        //U
        void Update(T obj);
        //D
        void Delete(T obj);
    }
}
