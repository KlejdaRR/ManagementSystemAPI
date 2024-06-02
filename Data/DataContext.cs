using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ManagementSystemAPI.Models;
using System.Collections.Generic;

namespace ManagementSystemAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskModel> TaskModels { get; set; }
    }
}