namespace WebApplication3.ShoppingListDataAccess
{
    public interface IShoppingList
    {
        void AddItemToList(string item);
        List<ShoppingItem> GetItems();
        void UpdateItem(int id, string name);
        void DeleteItem(int id);
    }
}
