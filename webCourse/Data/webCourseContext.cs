using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webCourse.Models
{
    public class WebCourseContext : DbContext
    {
        public WebCourseContext (DbContextOptions<WebCourseContext> options)
            : base(options)
        {
        }

        public DbSet<webCourse.Models.Department> Department { get; set; }
    }
}
