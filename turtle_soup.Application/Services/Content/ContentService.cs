namespace turtle_soup.Application.Services;

public class ContentService : IContentService, ITransient
{
    private readonly IRepository<SysContent> _contentRep;

    public ContentService(IRepository<SysContent> contentRep)
    {
        _contentRep = contentRep;
    }

    public IQueryable<SysContent> GetQueryable() => _contentRep.DetachedEntities;
}