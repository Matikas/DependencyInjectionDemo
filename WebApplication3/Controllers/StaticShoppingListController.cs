using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.ShoppingListDataAccess;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticShoppingListController : ControllerBase
    {
        [HttpGet]
        public List<string> GetAllItems()
        {
            return StaticShoppingList.GetItems();
        }

        [HttpPost]
        public void PostItem(string itemToAdd)
        {
            StaticShoppingList.AddItemToList(itemToAdd);
        }
    }
}
