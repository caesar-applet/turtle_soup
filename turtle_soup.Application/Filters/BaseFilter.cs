namespace turtle_soup.Application.Filters;

/// <summary>
/// 基础数组筛选
/// </summary>
public class BaseListFilter
{
    /// <summary>
    /// 模糊搜索
    /// </summary>
    public string Where { get; set; }
}

/// <summary>
/// 基础分页筛选
/// </summary>
public class BasePageFilter
{
    /// <summary>
    /// 页码
    /// </summary>
    [Required]
    public int PageIndex { get; set; } = 1;

    /// <summary>
    /// 每页数量
    /// </summary>
    [Required]
    public int PageSize { get; set; } = 20;

    /// <summary>
    /// 模糊搜索
    /// </summary>
    public string Where { get; set; }
}