namespace KiteTools.Repository.Abstract
{
    public interface IBaseRepository<TKey,TEntity>
    {
        Task<TEntity?> SelectById(TKey id);
    }
}