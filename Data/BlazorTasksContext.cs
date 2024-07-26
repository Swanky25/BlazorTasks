using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorTasks.Models;

namespace BlazorTasks.Data
{
    public class BlazorTasksContext : DbContext
    {
        public BlazorTasksContext (DbContextOptions<BlazorTasksContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorTasks.Models.Book> Book { get; set; } = default!;
    }
}
