using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext (DbContextOptions<CourseContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Course> Course { get; set; } = default!;
    }
}
