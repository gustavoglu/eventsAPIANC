using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Events.Infra.Identity.Models;
using Events.Domain.Models;

namespace Events.Infra.Identity.Data
{
    public class UsuarioContext : IdentityDbContext<Usuario>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Usuario>().ToTable("Usuario");
            builder.Entity<IdentityRole>().ToTable("Regra");
            builder.Entity<IdentityUserRole<string>>().ToTable("Usuario_Regra");
            builder.Entity<IdentityUserClaim<string>>().ToTable("Usuario_Claim");
            builder.Entity<IdentityUserLogin<string>>().ToTable("Usuario_Login");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("Regra_Claim");
            builder.Entity<IdentityUserToken<string>>().ToTable("Usuario_Tokens");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
