using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Question2.EntityFramework.Core
{
    [AppDbContext("Question2", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}