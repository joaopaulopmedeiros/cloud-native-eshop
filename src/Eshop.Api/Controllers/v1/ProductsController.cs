namespace Eshop.Api.Controllers;

[ApiController]
[Route("v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Product>> SearchAsync
    (
        [FromQuery] ProductsSearchRequest request, 
        [FromServices] ProductsSearchService service
    )
    {
        var products = await service.SearchAsync(request);
        return products;
    }
}
