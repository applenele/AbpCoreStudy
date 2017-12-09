using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreStudy.Configuration;

namespace AbpCoreStudy.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpCoreStudyWebCoreModule))]
    public class AbpCoreStudyWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreStudyWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreStudyWebHostModule).GetAssembly());
        }
    }
}
