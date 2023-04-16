using Microsoft.EntityFrameworkCore;

namespace BogusDataGenerator.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<AERecordModel> AERecords { get; set; } = default!;
    }
}
