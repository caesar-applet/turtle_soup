namespace turtle_soup.Core.Entity;

/// <summary>
/// 内容主题
/// </summary>
[Comment("内容主题")]
[Table("sys_content_theme")]
public class SysContentTheme : IEntity
{
    [Comment("内容Id")]
    public string ContentId { get; set; }

    [Comment("内容")]
    public SysContent Content { get; set; }

    [Comment("主题Id")]
    public string ThemeId { get; set; }

    [Comment("主题")]
    public SysTheme Theme { get; set; }
}