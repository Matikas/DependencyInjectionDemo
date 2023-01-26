using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.ShoppingListDataAccess;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListRepository _shoppingList;

        public ShoppingListController(IShoppingListRepository shoppingList)
        {
            _shoppingList = shoppingList;
        }

        [HttpGet]
        public List<ShoppingItem> GetAllItems()
        {
            return _shoppingList.GetItems();
        }

        [HttpPost]
        public void PostItem(ShoppingItemDto itemToAdd)
        {
            _shoppingList.AddItemToList(itemToAdd.Name);
        }

        [HttpPut]
        public void UpdateItem([FromQuery] int id, [FromBody] ShoppingItemDto item)
        {
            _shoppingList.UpdateItem(id, item.Name);
        }

        [HttpDelete]
        public void DeleteItem(int id)
        {
            _shoppingList.DeleteItem(id);
        }
    }
}
