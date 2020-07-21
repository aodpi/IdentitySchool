using System;
using IdentitySchool.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentitySchool.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.HasDefaultSchema("Identity");

            builder.Entity<ApplicationUser>()
                .ToTable("Users");

            builder.Entity<ApplicationRole>()
                .ToTable("Roles");

            builder.Entity<IdentityRoleClaim<Guid>>()
                .ToTable("RoleClaims");

            builder.Entity<IdentityUserToken<Guid>>()
                .ToTable("UserTokens");

            builder.Entity<IdentityUserClaim<Guid>>()
                .ToTable("UserClaims");

            builder.Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogins");

            builder.Entity<IdentityUserRole<Guid>>()
                .ToTable("UserRoles");
        }
    }
}
