using turtle_soup.Core.Enum;

namespace turtle_soup.Application.Dtos;

/// <summary>
/// 内容
/// </summary>
public class ContentDto
{
    /// <summary>
    /// 汤名
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 汤面
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 汤底
    /// </summary>
    public string Answer { get; set; }

    /// <summary>
    /// 难度
    /// </summary>
    public DifficultyEnum Difficulty { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 内容主题
    /// </summary>
    public List<ThemeDto> Themes { get; set; }
}

/// <summary>
/// 内容
/// </summary>
public class ContentCreate
{
    /// <summary>
    /// 汤名
    /// </summary>
    [Required(ErrorMessage = "汤名不能为空！")]
    public string Name { get; set; }

    /// <summary>
    /// 汤面
    /// </summary>
    [Required(ErrorMessage = "汤面能为空！")]
    public string Content { get; set; }

    /// <summary>
    /// 汤底
    /// </summary>
    [Required(ErrorMessage = "汤底不能为空！")]
    public string Answer { get; set; }

    /// <summary>
    /// 难度
    /// </summary>
    public DifficultyEnum Difficulty { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 内容主题Id
    /// </summary>
    public List<string> ThemeIds { get; set; }
}