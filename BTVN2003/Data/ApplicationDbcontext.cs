using System.Net.Mime;
using BTVN2003.Models;
using Microsoft.EntityFrameworkCore;

namespace BTVN2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
    }
}
