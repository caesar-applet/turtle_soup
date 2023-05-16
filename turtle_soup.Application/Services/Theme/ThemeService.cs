namespace turtle_soup.Application.Services;

/// <summary>
/// 主题服务
/// </summary>
public class ThemeService : IThemeService, ITransient
{
    private readonly IRepository<SysTheme> _themeRep;

    public ThemeService(IRepository<SysTheme> themeRep)
    {
        _themeRep = themeRep;
    }

    public IQueryable<SysTheme> GetQueryable() => _themeRep.DetachedEntities;
}