namespace turtle_soup.Application.AppServices;

public class GameAppService : BaseAppService
{
    private readonly IContentService _contentService;
    private readonly IContentThemeService _contentThemeService;

    public GameAppService(IContentService contentService, IContentThemeService contentThemeService)
    {
        _contentService = contentService;
        _contentThemeService = contentThemeService;
    }

    /// <summary>
    /// 获取汤面 - 数组
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [HttpPost("List")]
    public List<ContentDto> GetContentList(ContentFilter filter)
    {
        if (filter.ThemeIds.Count != 0)
        {
            return _contentThemeService.GetQueryable()
                .Where(x => filter.ThemeIds.Contains(x.ContentId))
                .Include(x => x.Content).ThenInclude(x => x.Themes)
                .Where(!string.IsNullOrEmpty(filter.Where), x => x.Content.Name.Contains(filter.Where) || x.Content.Content.Contains(filter.Where))
                .Where(filter.Difficulty != null, x => x.Content.Difficulty == filter.Difficulty)
                .ProjectToType<ContentDto>()
                .ToList();
        }
        else
        {
            return _contentService.GetQueryable()
                .Include(x => x.Themes)
                .Where(!string.IsNullOrEmpty(filter.Where), x => x.Name.Contains(filter.Where) || x.Content.Contains(filter.Where))
                .Where(filter.Difficulty != null, x => x.Difficulty == filter.Difficulty)
                .ProjectToType<ContentDto>()
                .ToList();
        }
    }
}