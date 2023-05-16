namespace turtle_soup.Application.Services;

/// <summary>
/// 内容主题服务
/// </summary>
public class ContentThemeService : IContentThemeService, ITransient
{
    private readonly IRepository<SysContentTheme> contentThemeRep;

    public ContentThemeService(IRepository<SysContentTheme> contentThemeRep)
    {
        this.contentThemeRep = contentThemeRep;
    }

    public IQueryable<SysContentTheme> GetQueryable() => contentThemeRep.DetachedEntities;
}