using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WeixinProject.EntityFrameworkCore
{
    public static class WeixinProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WeixinProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WeixinProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
