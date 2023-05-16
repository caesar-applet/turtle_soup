namespace turtle_soup.Application.AppServices;

/// <summary>
/// 主题服务接口
/// </summary>
public class ThemeAppService : BaseAppService
{
    private readonly IThemeService _themeService;

    public ThemeAppService(IThemeService themeService)
    {
        _themeService = themeService;
    }
}