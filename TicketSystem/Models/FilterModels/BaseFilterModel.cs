
public class BaseFilterModel
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string OrderBy { get; set; }
    public string OrderByDirection { get; set; }
}