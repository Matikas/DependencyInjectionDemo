namespace WebApplication3.ShoppingListDataAccess
{
    public interface IShoppingList
    {
        void AddItemToList(string item);
        List<string> GetItems();
    }
}
