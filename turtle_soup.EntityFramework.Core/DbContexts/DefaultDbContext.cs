using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace turtle_soup.EntityFramework.Core;

[AppDbContext("turtle_soup", DbProvider.SqlServer)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}