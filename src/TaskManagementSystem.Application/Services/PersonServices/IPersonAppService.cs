using System;
using Abp.Application.Services;
using TaskManagementSystem.Services.PersonServices.Dtos;

namespace TaskManagementSystem.Services.PersonServices
{
    public interface IPersonAppService : IAsyncCrudAppService<CreatePersonDto, Guid>
    {
    }
}
