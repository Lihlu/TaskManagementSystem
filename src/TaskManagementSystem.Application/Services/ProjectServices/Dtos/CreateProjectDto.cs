using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TaskManagementSystem.Domain.Person;

namespace TaskManagementSystem.Services.ProjectServices.Dtos
{
    [AutoMap(typeof(Project))]
    public class CreateProjectDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
