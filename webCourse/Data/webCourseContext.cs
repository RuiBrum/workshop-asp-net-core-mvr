using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webCourse.Models;

namespace webCourse.Models
{
    public class WebCourseContext : DbContext
    {
        public WebCourseContext (DbContextOptions<WebCourseContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().Property(b => b.id_tabelionato).HasDefaultValue(1);
            modelBuilder.Entity<Usuarios>().HasIndex(b => b.login).HasName("Ix_UsuarioLogin");
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }

    }
}
