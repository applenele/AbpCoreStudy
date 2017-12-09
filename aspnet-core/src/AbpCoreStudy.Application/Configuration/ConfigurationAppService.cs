using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpCoreStudy.Configuration.Dto;

namespace AbpCoreStudy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpCoreStudyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
