using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreStudy.Authorization;

namespace AbpCoreStudy
{
    [DependsOn(
        typeof(AbpCoreStudyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpCoreStudyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpCoreStudyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpCoreStudyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
