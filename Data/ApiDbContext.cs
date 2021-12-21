using Microsoft.EntityFrameworkCore;

namespace webapi.Data {

        public class ApiDbContext : DbContext {
        public DbSet<Artist> Artist {get; set;}

        public DbSet<Vinyl> Vinyl {get; set;}

        public DbSet<RecordLabel> RecordLabel {get; set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> opt) : base(opt)
        {

        }

       
    }
}