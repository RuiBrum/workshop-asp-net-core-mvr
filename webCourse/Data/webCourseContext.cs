using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webCourse.Models
{
    public class webCourseContext : DbContext
    {
        public webCourseContext (DbContextOptions<webCourseContext> options)
            : base(options)
        {
        }

        public DbSet<webCourse.Models.Department> Department { get; set; }
    }
}
