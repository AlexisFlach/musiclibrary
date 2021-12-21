### 1. SETUP MYSQL

1. 
dotnet new webapi -n NAME

2.
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet

migration-first

dotnet ef dbcontext scaffold "connectionstring" "Pomelo.EntityFrameworkCore.MySql"

3.


```
using Microsoft.EntityFrameworkCore;

namespace webapi.Data {

        public class ApplicationDbContext : DbContext {
        public DbSet<Artist> Artist {get; set;}

        public DbSet<Vinyl> Vinyl {get; set;}

        public DbSet<RecordLabel> RecordLabel {get; set;}

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;user=root;port=3306;database=musicdb;",
            new MySqlServerVersion(new Version(8, 0, 11))
        );
    }

  }
}
```

dotnet ef migrations add InitialCreate
dotnet ef database update

### 2. Register and login