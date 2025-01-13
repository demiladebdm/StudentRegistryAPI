using Microsoft.EntityFrameworkCore;
//using BankService.Models;

namespace BankService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //public DbSet<Student> Students { get; set; }
    }
}
