namespace Eshop.Api.Services;

public class ProductsSearchService
{
    private readonly static string[] Names = new[] {
        "PS5",
        "Xbox One",
        "Monitor Ultrawide LG",
        "Keychron K3 V2"
    };

    public async Task<IEnumerable<Product>> SearchAsync(ProductsSearchRequest request) {
        var products = Enumerable.Range(0, 4).Select(index => new Product
        {
            Name = Names[index]
        })
        .Where(p => string.IsNullOrEmpty(request.Name) || p.Name.Contains(request.Name, StringComparison.InvariantCultureIgnoreCase))
        .Skip((request.Page - 1) * request.PageSize)
        .Take(request.PageSize)
        .ToArray();
        return await Task.FromResult(products);
    }
}