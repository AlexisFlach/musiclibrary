using Microsoft.EntityFrameworkCore;

namespace webapi.Data {

        public class ApiDbContext : DbContext {
        public DbSet<Artist> Artist {get; set;}

        public DbSet<Vinyl> Vinyl {get; set;}

        public DbSet<RecordLabel> RecordLabel {get; set;}

        public DbSet<MusicCategory> Category {get; set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

        }

       
    }
}