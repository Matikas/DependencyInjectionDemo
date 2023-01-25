namespace WebApplication3.ShoppingListDataAccess
{
    public class ShoppingList : IShoppingList
    {
        private List<string> _items = new List<string>();

        public void AddItemToList(string item)
        {
            _items.Add(item);
        }

        public List<string> GetItems()
        {
            return _items;
        }
    }
}
