using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Domain.Person
{
    public enum RefListTaskStatus
    {
        [Description("Upcoming")]
        Upcoming,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed
    }
}
