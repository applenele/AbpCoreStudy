using System.Threading.Tasks;
using AbpCoreStudy.Configuration.Dto;

namespace AbpCoreStudy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
