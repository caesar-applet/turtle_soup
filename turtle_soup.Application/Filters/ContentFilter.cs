namespace turtle_soup.Application.Filters;

public class ContentFilter : BaseListFilter
{
    /// <summary>
    /// 难度
    /// </summary>
    public DifficultyEnum? Difficulty { get; set; }

    /// <summary>
    /// 主题Id数组
    /// </summary>
    public List<string> ThemeIds { get; set; } = new List<string>();
}