using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreStudy.Authorization.Accounts.Dto;

namespace AbpCoreStudy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
