using ECommerce.BLL.Interfaces;
using ECommerce.DAL.Models;

namespace ECommerce.BLL.Srevices
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        public GeneralRepository(ECommerceContext db )
        {
            Db = db;
        }

        public ECommerceContext Db { get; }
        #region Add new Item
        public async Task<int> Add(T t)
        {
            await Db.Set<T>().AddAsync(t);
            return await Db.SaveChangesAsync();
        }
        #endregion
        #region Remove 
        public int Delete(T t)
        {
            Db.Set<T>().Remove(t);
            return Db.SaveChanges();
        }
        #endregion
        #region GetALl
        public async Task<List<T>> GetAll()
        {
            return Db.Set<T>().ToList();
        }
        #endregion
        #region Get by id
        public async Task<T> GetById(int id)
        {
            return await Db.Set<T>().FindAsync(id);
        }
        #endregion 
    }
}
