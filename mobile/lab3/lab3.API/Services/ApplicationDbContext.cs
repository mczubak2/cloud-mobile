using System;
using Lab3_app.Repositories;
using Microsoft.EntityFrameworkCore;

namespace lab3.API.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
    }
}
