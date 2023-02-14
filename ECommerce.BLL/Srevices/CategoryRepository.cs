namespace ECommerce.BLL.Srevices
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceContext db) : base(db)
        {
        }

        public List<Category> GetCategoryByName(string name)
        {
            return  Db.Categories.Where(c => c.Name == name).ToList();
        }

        public  int UpdateCategory(int id, Category category)
        {
            Category old = Db.Categories.Find(category.ID);
            if(old is null || old.ID != id)
            {
                return -1;
            }
            old.Description = category.Description;
            old.Name = category.Name;
            return Db.SaveChanges();
        }
    }
}
