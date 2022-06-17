using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands;
using Shop.Domain.Handlers;

namespace Shop.Api.Controllers;

[ApiController]
[Route("v1/shop/list")]
public class ShopListController : ControllerBase
{

    [HttpGet]
    [Route("")]
    public CommandResult ReadAllShopList(
        [FromServices] ShopHandler handler
    )
    {
        var command = new ReadAllShopListCommand();

        return handler.Handle(command);
    }

     [HttpPost]
    [Route("")]
    public CommandResult CreateShopList(
        [FromBody] CreateShopListCommand command,
        [FromServices] ShopHandler handler
    ) 
    {
        return handler.Handle(command);
    }
}