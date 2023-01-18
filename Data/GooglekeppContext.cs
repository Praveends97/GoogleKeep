using GoogleKeep.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace GoogleKeep.Data
{
    public class GooglekeppContext : DbContext
    {
        public GooglekeppContext(DbContextOptions<GooglekeppContext> options)
            : base(options)
        {
        }

        public DbSet<Googlekeep> Googlekeep { get; set; }
    }
}

