using TaskMenager.Models;
using Microsoft.EntityFrameworkCore;
namespace TaskMenager.Data
{
    public class ApplicationDBContext:DbContext
    {
        
        
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }
          public DbSet<TaskModel> Tasks { get; set; }
    }
}
