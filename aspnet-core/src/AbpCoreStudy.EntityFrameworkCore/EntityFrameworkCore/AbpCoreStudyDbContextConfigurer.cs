using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpCoreStudy.EntityFrameworkCore
{
    public static class AbpCoreStudyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpCoreStudyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpCoreStudyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
