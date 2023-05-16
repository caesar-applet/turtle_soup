namespace turtle_soup.Application.Services;

public interface IContentService
{
    IQueryable<SysContent> GetQueryable();
}