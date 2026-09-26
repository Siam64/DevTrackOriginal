using Microsoft.EntityFrameworkCore;
using DevTrack.Domain.Entities;

namespace DevTrack.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueComment> IssueComments { get; set; }
        public DbSet<IssueHistory> IssueHistories { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
