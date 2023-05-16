namespace turtle_soup.Application.AppServices;

/// <summary>
/// 服务基类
/// </summary>
[ApiDescriptionSettings()]
public abstract class BaseAppService : IDynamicApiController
{
    protected BaseAppService()
    {
    }
}