using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpCoreStudy.Authorization.Roles;
using AbpCoreStudy.Authorization.Users;
using AbpCoreStudy.MultiTenancy;

namespace AbpCoreStudy.EntityFrameworkCore
{
    public class AbpCoreStudyDbContext : AbpZeroDbContext<Tenant, Role, User, AbpCoreStudyDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public AbpCoreStudyDbContext(DbContextOptions<AbpCoreStudyDbContext> options)
            : base(options)
        {
        }
    }
}
