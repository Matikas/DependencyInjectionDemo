namespace WebApplication3.ShoppingListDataAccess
{
    public interface IShoppingListRepository
    {
        void AddItemToList(string item);
        List<ShoppingItem> GetItems();
        void UpdateItem(int id, string name);
        void DeleteItem(int id);
    }
}
