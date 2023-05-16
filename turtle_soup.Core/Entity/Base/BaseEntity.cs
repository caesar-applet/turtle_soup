using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace turtle_soup.Core.Entity;

/// <summary>
/// 实体基类
/// </summary>
[SuppressSniffer]
public abstract class BaseEntity : IEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Comment("Id主键")]
    [Column(TypeName = "varchar(36)")]
    public string Id { get; set; } = Guid.NewGuid().ToString();
}