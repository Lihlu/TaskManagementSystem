using Abp.Application.Services;
using TaskManagementSystem.Sessions.Dto;
using System.Threading.Tasks;

namespace TaskManagementSystem.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
