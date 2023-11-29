namespace Eshop.Api.Controllers.v1;

[ApiController]
[Route("[controller]")]
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
