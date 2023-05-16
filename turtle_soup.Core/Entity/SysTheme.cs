namespace turtle_soup.Core.Entity;

/// <summary>
/// 内容主题
/// </summary>
[Comment("内容主题")]
[Table("sys_theme")]
public class SysTheme : BaseEntity
{
    [Comment("主题名字")]
    public string Name { get; set; }

    public ICollection<SysContent> Contents { get; set; }

    public ICollection<SysContentTheme> ContentThemes { get; set; }
}