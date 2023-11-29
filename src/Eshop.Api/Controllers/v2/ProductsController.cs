namespace Eshop.Api.Controllers.v2;

[ApiController]
[Route("v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Product>> SearchAsync2
    (
        [FromQuery] ProductsSearchRequest request, 
        [FromServices] ProductsSearchService service
    )
    {
        var products = await service.SearchAsync(request);
        return products;
    }
}
