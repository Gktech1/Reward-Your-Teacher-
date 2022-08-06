using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain
{
    public class UserManagementDbContext : IdentityDbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<School> Schools { get; set; }


    }

}
