### Yes

Useful snippets

dotnet new webapi -n NAME

dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet

migration-first

dotnet ef dbcontext scaffold "connectionstring" "Pomelo.EntityFrameworkCore.MySql"


dotnet ef migrations add InitialCreate
dotnet ef database update

2. Jwt

Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Identity.UI



1. Configure JWT

appsettings.json

 "JwtConfig": {
    "Secret": "XDLqCCjArSWRhGspcHNLBCVAkcybbqbD"
  },

Configuration/JwtConfig.cs

Mappar det som finns i appsettings.

```
public class JwtConfig
    {
       public string Secret { get; set; } 
    }
```

services

builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

I stort betyder detta att vi kan läsa vår secret varsomhelst i vår applikation

```
builder.Services.AddAuthentication(opt => {
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(jwt => {
    var key = Encoding.ASCII.GetBytes(builder.Configuration["JwtConfig:Secret"]);

    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        RequireExpirationTime = false
    };
});

builder.Services.AddDefaultIdentity<IdentityUser>(opt => opt.SignIn.RequireConfirmedAccount = true )
.AddEntityFrameworkStores<ApiDbContext>();
```

https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio

public class ApiDbContext : IdentityDbContext {



dotnet ef migrations add "Add authentication tables to our api"

dotnet ef database update


configuration/AuthResult



 public class AuthResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }

        public List<string> Errors { get; set; }
    }

    Ansvarar för dtos

    Dtos/Requests

    Dtos/Responses