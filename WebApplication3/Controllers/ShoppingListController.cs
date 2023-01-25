using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.ShoppingListDataAccess;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingList _shoppingList;

        public ShoppingListController(IShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }

        [HttpGet]
        public List<string> GetAllItems()
        {
            return _shoppingList.GetItems();
        }

        [HttpPost]
        public void PostItem(string itemToAdd)
        {
            _shoppingList.AddItemToList(itemToAdd);
        }
    }
}
