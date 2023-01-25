namespace WebApplication3.ShoppingListDataAccess
{
    public static class StaticShoppingList
    {
        private static List<string> _items = new List<string>();

        public static void AddItemToList(string item)
        {
            _items.Add(item);
        }

        public static List<string> GetItems()
        {
            return _items;
        }
    }
}
