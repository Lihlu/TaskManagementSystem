using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TaskManagementSystem.Domain.Person;

namespace TaskManagementSystem.Services.ProjectTaskServices.Dtos
{
    [AutoMap(typeof(ProjectTask))]
    public class ProjectTaskDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public RefListTaskStatus Status { get; set; }
        public string ProjectId { get; set; }
        public long AssignedUserId { get; set; }
    }
}
