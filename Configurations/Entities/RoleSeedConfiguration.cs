using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "69d10e4c-0427-4448-a13e-104c439ae422",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "69d10e4c-0427-4ee6-a13e-104c439aebba",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            );
        }
    }
}