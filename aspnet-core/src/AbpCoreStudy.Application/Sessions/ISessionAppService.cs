using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreStudy.Sessions.Dto;

namespace AbpCoreStudy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
