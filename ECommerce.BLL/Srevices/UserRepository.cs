using ECommerce.BLL.Interfaces;

namespace ECommerce.BLL.Srevices
{
    public class UserRepository : GeneralRepository<UserRepository>, IUserRepository
    {
        public UserRepository(ECommerceContext db) : base(db)
        {
        }
    }
}
