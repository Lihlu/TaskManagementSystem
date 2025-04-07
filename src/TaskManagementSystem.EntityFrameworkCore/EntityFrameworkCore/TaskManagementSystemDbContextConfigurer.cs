using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace TaskManagementSystem.EntityFrameworkCore;

public static class TaskManagementSystemDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<TaskManagementSystemDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<TaskManagementSystemDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
