using System.ComponentModel;

namespace turtle_soup.Core.Enum;

/// <summary>
/// 难度枚举
/// </summary>
public enum DifficultyEnum
{
    [Description("入门")]
    Beginner,

    [Description("普通")]
    Medium,

    [Description("困难")]
    Difficulty
}