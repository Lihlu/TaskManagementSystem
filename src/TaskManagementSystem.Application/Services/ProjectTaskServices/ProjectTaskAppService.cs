using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using TaskManagementSystem.Authorization;
using TaskManagementSystem.Domain.Person;
using TaskManagementSystem.Services.ProjectTaskServices.Dtos;

namespace TaskManagementSystem.Services.ProjectTaskServices
{
    public class ProjectTaskAppService : AsyncCrudAppService<ProjectTask, ProjectTaskDto, Guid>, IProjectTaskAppService
    {
        public ProjectTaskAppService(IRepository<ProjectTask, Guid> repository) : base(repository)
        {
            
        }



    }
}
