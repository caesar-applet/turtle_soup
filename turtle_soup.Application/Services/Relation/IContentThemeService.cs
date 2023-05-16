namespace turtle_soup.Application.Services;

/// <summary>
/// 内容主题服务
/// </summary>
public interface IContentThemeService
{
    IQueryable<SysContentTheme> GetQueryable();
}