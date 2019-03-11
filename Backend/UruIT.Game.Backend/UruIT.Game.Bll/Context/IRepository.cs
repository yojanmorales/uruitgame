using System.Collections.Generic;
using System.Linq;

namespace UruIT.Game.Bll.Context
{
    public interface IRepository<T>
    {
        T Get<TKey>(TKey id);
        IQueryable<T> GetAll();
        T Add(T entity);
        IList<T> Add(IList<T> entity);
        void Update(T entity);
    }
}
