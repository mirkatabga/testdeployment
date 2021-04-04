using Microsoft.EntityFrameworkCore;
using System;
using TestDeployment.Database.DTOs;

namespace TestDeployment.Database
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options)
        {           
        }

        public DbSet<Test> Tests { get; set; }
    }
}
