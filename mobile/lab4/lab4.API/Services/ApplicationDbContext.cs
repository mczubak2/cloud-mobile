
using System;
using lab4.Repo;
using Microsoft.EntityFrameworkCore;

namespace lab4.API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
    }
}