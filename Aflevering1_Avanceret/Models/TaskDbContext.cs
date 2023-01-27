using Microsoft.EntityFrameworkCore;

namespace Aflevering1_Avanceret.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options) { }
        public DbSet<Task> Tasks { get; set; }
    }
}
