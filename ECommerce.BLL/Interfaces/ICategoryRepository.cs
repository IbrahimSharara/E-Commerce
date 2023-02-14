namespace ECommerce.BLL.Interfaces
{
    public interface ICategoryRepository : IGeneralRepository<Category>
    {
        List<Category> GetCategoryByName(string name);
        int UpdateCategory(int id , Category category);
    }
}
