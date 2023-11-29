namespace Eshop.Api.Controllers.v1;

[ApiController]
[Route("v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Product>> SearchAsync([FromServices] ProductsSearchService service)
    {
        var products = await service.SearchAsync();
        return products;
    }
}
