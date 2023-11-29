namespace Eshop.Api.Requests;

public class ProductsSearchRequest : PaginatedSearchRequest
{
    public string? Name { get; set; }
}
