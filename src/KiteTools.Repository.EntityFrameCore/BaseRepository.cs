using KiteTools.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace KiteTools.Repository.EntityFrameCore
{
    public class BaseRepository<TKey, TEntity> : IBaseRepository<TKey, TEntity> where TEntity : class
    {

        protected DbSet<TEntity> Table { get; }
        public BaseRepository(DbContext context)
        {
            Context = context;
            Table = context.Set<TEntity>();
        }

        public DbContext Context { get; }

        public async Task<TEntity?> SelectById(TKey id)
        {
            return await Table.FindAsync(id);
        }
    }
}