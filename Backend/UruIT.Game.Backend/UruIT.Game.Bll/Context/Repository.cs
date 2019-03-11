using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UruIT.Game.Bll.Context
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> DbSet;

        public Repository(GameDbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public T Add(T entity)
        {
            Context.Set<T>().Add(entity);

            Save();

            return entity;
        }

        public IList<T> Add(IList<T> entity)
        {
            Context.Set<T>().AddRange(entity);

            Save();

            return entity;
        }

        public T Get<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
