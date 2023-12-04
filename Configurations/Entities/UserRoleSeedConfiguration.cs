using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "69d10e4c-0427-4448-a13e-104c439ae422",
                    UserId = "69d10e4c-0427-4ee6-a13e-104c439ae888"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "69d10e4c-0427-4ee6-a13e-104c439aebba",
                    UserId = "f536c75a-a460-4ecb-a949-58305ba11968"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "69d10e4c-0427-4ee6-a13e-104c439aebba",
                     UserId = "f536c75a-a460-4ecb-a949-58305ba11977"
                 }

                );
            
        }
    }
}