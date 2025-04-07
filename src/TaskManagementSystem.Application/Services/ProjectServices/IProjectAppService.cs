using System;
using Abp.Application.Services;
using TaskManagementSystem.Services.ProjectServices.Dtos;

namespace TaskManagementSystem.Services.ProjectServices
{
    public interface IProjectAppService : IAsyncCrudAppService<CreateProjectDto, Guid>
    {

    }
}
