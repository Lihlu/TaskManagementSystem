using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using TaskManagementSystem.Domain.Person;
using TaskManagementSystem.Services.ProjectServices.Dtos;

namespace TaskManagementSystem.Services.ProjectServices
{
    public class ProjectAppService : AsyncCrudAppService<Project, CreateProjectDto, Guid>, IProjectAppService
    {
        public ProjectAppService(IRepository<Project, Guid> repository) : base(repository)
        {
        }
    }
}
