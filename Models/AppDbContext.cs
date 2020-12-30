using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace SchoolManagementMVC.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 
        }
        public DbSet<School> Schools {get; set;}
        public DbSet<Teacher> Teachers {get;set;}
        public DbSet<Student> Students {get;set;}
    }
}