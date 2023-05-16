namespace turtle_soup.Application.Services;

/// <summary>
/// 主题服务
/// </summary>
public interface IThemeService
{
    IQueryable<SysTheme> GetQueryable();
}