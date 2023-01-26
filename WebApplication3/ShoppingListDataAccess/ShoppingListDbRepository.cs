namespace WebApplication3.ShoppingListDataAccess
{
    public class ShoppingListDbRepository : IShoppingListRepository
    {
        private readonly ShoppingListDbContext _context;

        public ShoppingListDbRepository(ShoppingListDbContext context)
        {
            _context = context;
        }

        public void AddItemToList(string item)
        {
            _context.ShoppingItems.Add(new ShoppingItem { Name = item });
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            _context.ShoppingItems.Remove(new ShoppingItem { Id = id });
            _context.SaveChanges();
        }

        public List<ShoppingItem> GetItems()
        {
            return _context.ShoppingItems.ToList();
        }

        public void UpdateItem(int id, string name)
        {
            var itemFromDb = _context.ShoppingItems.FirstOrDefault(i => i.Id == id);
            itemFromDb.Name = name;
            _context.SaveChanges();
        }
    }
}
