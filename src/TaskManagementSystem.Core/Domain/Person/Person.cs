using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using TaskManagementSystem.Authorization.Users;

namespace TaskManagementSystem.Domain.Person
{
    public class Person : FullAuditedEntity<Guid>
    {
        public Address Address { get; set; }
        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
