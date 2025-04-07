using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace TaskManagementSystem.Domain.Person
{
    public class Attachment : FullAuditedEntity<Guid>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        [NotMapped]
        public ProjectTask Task { get; set; }

    }
}
