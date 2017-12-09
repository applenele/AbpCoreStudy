using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpCoreStudy.Configuration;
using AbpCoreStudy.Web;

namespace AbpCoreStudy.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpCoreStudyDbContextFactory : IDesignTimeDbContextFactory<AbpCoreStudyDbContext>
    {
        public AbpCoreStudyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpCoreStudyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpCoreStudyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpCoreStudyConsts.ConnectionStringName));

            return new AbpCoreStudyDbContext(builder.Options);
        }
    }
}
