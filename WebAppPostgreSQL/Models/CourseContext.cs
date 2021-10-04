using System;
using Microsoft.EntityFrameworkCore;

namespace WebAppPostgreSQL.Models
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
        //Table Name StudentDetails
    }
}
