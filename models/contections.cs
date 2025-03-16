using Microsoft.EntityFrameworkCore;
namespace TaskApi.models;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options)
        : base(options)
    {}

    public DbSet<Task> Task { get; set; } = null!;
}