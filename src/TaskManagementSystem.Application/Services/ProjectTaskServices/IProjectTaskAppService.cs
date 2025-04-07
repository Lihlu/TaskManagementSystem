using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TaskManagementSystem.Services.ProjectTaskServices.Dtos;

namespace TaskManagementSystem.Services.ProjectTaskServices
{
    public interface IProjectTaskAppService : IAsyncCrudAppService<ProjectTaskDto, Guid>
    {
    }
}
