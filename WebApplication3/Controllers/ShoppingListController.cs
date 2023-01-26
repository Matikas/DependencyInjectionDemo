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
        private readonly ILogger<ShoppingListController> _logger;

        public ShoppingListController(IShoppingListRepository shoppingList, ILogger<ShoppingListController> logger)
        {
            _shoppingList = shoppingList;
            _logger = logger;
        }

        [HttpGet]
        public List<ShoppingItem> GetAllItems()
        {
            return _shoppingList.GetItems();
        }

        [HttpPost]
        public void PostItem(ShoppingItemDto itemToAdd)
        {
            _logger.LogInformation($"User is trying to add shopping list item: {itemToAdd.Name}");
            _shoppingList.AddItemToList(itemToAdd.Name);
            _logger.LogInformation("Item was added to database");
        }

        [HttpPut]
        public void UpdateItem([FromQuery] int id, [FromBody] ShoppingItemDto item)
        {
            try
            {
                _logger.LogInformation($"trying to update item with id {id} to be {item.Name}");
                _shoppingList.UpdateItem(id, item.Name);
                _logger.LogInformation("update was successful");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Error occured when updating item {id}");
                throw;
            }
        }

        [HttpDelete]
        public void DeleteItem(int id)
        {
            _logger.LogWarning($"user is about to delete item with id {id}");
            _shoppingList.DeleteItem(id);
        }
    }
}
