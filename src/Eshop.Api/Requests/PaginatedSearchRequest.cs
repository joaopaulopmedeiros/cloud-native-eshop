namespace Eshop.Api.Requests;

public class PaginatedSearchRequest
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}