using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands;
using Shop.Domain.Handlers;

namespace Shop.Api.Controllers;

[ApiController]
[Route("v1/shop/list/items")]
public class ShopItemController : ControllerBase
{

    [HttpPost]
    [Route("")]
    public CommandResult CreateShopItem(
        [FromBody] CreateShopItemCommand command,
        [FromServices] ShopHandler handler
    )
    {
        return handler.Handle(command);
    }

    [HttpPut]
    [Route("")]
    public CommandResult UpdateItem(
        [FromBody] UpdateShopItemCommand command,
        [FromServices] ShopHandler handler
    )
    {
        return handler.Handle(command);
    }

    [HttpGet]
    [Route("")]
    public CommandResult ReadShopListItemsById(
        [FromBody] ReadAllShopItemCommand command,
        [FromServices] ShopHandler handler
    )
    {
        return handler.Handle(command);
    }

    [HttpDelete]
    [Route("{id:Guid}")]
    public CommandResult DeleteItemsById(
        [FromRoute] Guid id,
        [FromServices] ShopHandler handler
    )
    {
        DeleteShopItemCommand command = new();
        command.Id = id;
        return handler.Handle(command);
    }

}