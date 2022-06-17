using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands;
using Shop.Domain.Handlers;

namespace Shop.Api.Controllers;

[ApiController]
[Route("v1/shop")]
public class ShopItemController : ControllerBase
{

    [HttpPost]
    [Route("item")]
    public CommandResult CreateShopItem(
        [FromBody] CreateShopItemCommand command,
        [FromServices] ShopHandler handler
    ) 
    {
        return handler.Handle(command);
    }
}