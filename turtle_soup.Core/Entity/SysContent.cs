namespace turtle_soup.Core.Entity;

/// <summary>
/// 海龟汤内容
/// </summary>
[Comment("海龟汤内容")]
[Table("sys_content")]
public class SysContent : BaseEntity, IEntityTypeBuilder<SysContent>
{
    [Comment("汤名")]
    public string Name { get; set; }

    [Comment("汤面")]
    public string Content { get; set; }

    [Comment("汤底")]
    public string Answer { get; set; }

    [Comment("难度")]
    public DifficultyEnum Difficulty { get; set; }

    [Comment("访问量")]
    public int Views { get; set; } = 0;

    [Comment("点赞量")]
    public int Likes { get; set; } = 0;

    [Comment("备注")]
    public string Remark { get; set; }

    public ICollection<SysTheme> Themes { get; set; }

    public ICollection<SysContentTheme> ThemeContents { get; set; }

    public void Configure(EntityTypeBuilder<SysContent> entityBuilder, DbContext dbContext, Type dbContextLocator)
    {
        // 内容主题
        entityBuilder
            .HasMany(c => c.Themes).WithMany(t => t.Contents).UsingEntity<SysContentTheme>(
            er => er.HasOne(r => r.Theme).WithMany(t => t.ContentThemes).HasForeignKey(r => r.ThemeId).OnDelete(DeleteBehavior.Cascade),
            er => er.HasOne(r => r.Content).WithMany(c => c.ThemeContents).HasForeignKey(r => r.ContentId).OnDelete(DeleteBehavior.Cascade),
            er => er.HasKey(r => new { r.ContentId, r.ThemeId }));
    }
}