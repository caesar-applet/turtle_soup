namespace turtle_soup.Application.Dtos;

/// <summary>
/// 主题
/// </summary>
public class ThemeDto
{
    /// <summary>
    /// 主题Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// 主题名称
    /// </summary>
    public string Name { get; set; }
}

/// <summary>
/// 主题
/// </summary>
public class ThemeCreate
{
    /// <summary>
    /// 主题名称
    /// </summary>
    public string Name { get; set; }
}