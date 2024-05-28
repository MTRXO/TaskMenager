using TaskMenagerModels;
using Microsoft.EntityFrameworkCore;

namespace DataAcces
{
    public class ApplicationDBContext:DbContext
    {
           
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }
          public DbSet<TaskModel> Tasks { get; set; }
    }
}
