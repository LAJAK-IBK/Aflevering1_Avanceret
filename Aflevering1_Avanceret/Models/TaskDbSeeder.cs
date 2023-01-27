using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Aflevering1_Avanceret.Models
{
    public class TaskDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new TaskDbContext(serviceProvider.GetRequiredService<DbContextOptions<TaskDbContext>>());

            if (context.Tasks.Any())
            {
                return;
            }
            context.Tasks.AddRange(
                new Task
                {
                    Id = 1,
                    TaskName = "Agurker",
                    Location = Locations.Frugtoggrønt,
                    Quantity = 2,
                    Unit = Units.Styk,
                    IsComplete = false
                },

                new Task
                {
                    Id = 2,
                    TaskName = "Tomater",
                    Location = Locations.Frugtoggrønt,
                    Quantity = 5,
                    Unit = Units.Styk,
                    IsComplete = false
                }
            );
            context.SaveChanges();
        }
    }
}
