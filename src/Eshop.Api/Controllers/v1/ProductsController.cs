namespace Eshop.Api.Controllers;

[ApiController]
[Route("v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ProductsController : ControllerBase
{
    private static readonly string[] Names = new[]
    {
        "PS5", "Xbox One", "Iphone", "Monitor LG Ultrawide"
    };

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        return Enumerable.Range(0, 4).Select(index => new Product
        {
            Name = Names[index]
        })
        .ToArray();
    }
}
