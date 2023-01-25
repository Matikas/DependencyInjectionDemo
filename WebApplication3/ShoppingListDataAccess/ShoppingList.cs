namespace WebApplication3.ShoppingListDataAccess
{
    public class ShoppingList : IShoppingList
    {
        private int _lastId;
        private List<ShoppingItem> _items = new List<ShoppingItem>();

        public void AddItemToList(string item)
        {
            _lastId++;
            _items.Add(new ShoppingItem
            {
                Id = _lastId,
                Name = item,
            });
        }

        public List<ShoppingItem> GetItems()
        {
            return _items;
        }

        public void UpdateItem(int id, string name)
        {
            var existingItem = _items.FirstOrDefault(i => i.Id == id);
            existingItem.Name = name;
        }

        public void DeleteItem(int id)
        {
            var itemToDelete = _items.FirstOrDefault(i => i.Id == id);
            _items.Remove(itemToDelete);
        }
    }
}
