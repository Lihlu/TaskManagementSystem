using Abp.Zero.EntityFrameworkCore;
using TaskManagementSystem.Authorization.Roles;
using TaskManagementSystem.Authorization.Users;
using TaskManagementSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Domain.Person;

namespace TaskManagementSystem.EntityFrameworkCore;

public class TaskManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, TaskManagementSystemDbContext>
{
    /* Define a DbSet for each entity of the application */
    public DbSet<Person> Persons { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectTask> Tasks { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public TaskManagementSystemDbContext(DbContextOptions<TaskManagementSystemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>(b =>
        {
            b.OwnsOne(p => p.Address);
        });
    }
}
