using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using TaskManagementSystem.Authorization.Users;

namespace TaskManagementSystem.Domain.Person
{
    public class Project : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
        [NotMapped]
        public IListResult<ProjectTask> Tasks { get; set; }
    }
}
