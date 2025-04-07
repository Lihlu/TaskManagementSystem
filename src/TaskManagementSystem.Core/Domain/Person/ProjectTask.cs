using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using TaskManagementSystem.Authorization.Users;

namespace TaskManagementSystem.Domain.Person
{
    public class ProjectTask : FullAuditedEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public RefListTaskStatus Status { get; set; }
        [NotMapped]
        public IList<Attachment> Attachments { get; set; }
        public string ProjectId { get; set; }
        public long AssignedUserId { get; set; }
    }
}
