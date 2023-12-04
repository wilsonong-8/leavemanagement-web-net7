using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "69d10e4c-0427-4ee6-a13e-104c439ae888",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    UserName = "admin@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "f536c75a-a460-4ecb-a949-58305ba11968",
                     Email = "user@gmail.com",
                     NormalizedEmail = "USER@GMAIL.COM",
                     NormalizedUserName = "USER@GMAIL.COM",
                     UserName = "user@gmail.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                  new Employee
                  {
                      Id = "f536c75a-a460-4ecb-a949-58305ba11977",
                      Email = "user2@gmail.com",
                      NormalizedEmail = "USER2@GMAIL.COM",
                      NormalizedUserName = "USER2@GMAIL.COM",
                      UserName = "user2@gmail.com",
                      FirstName = "John",
                      LastName = "Doe",
                      PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                      EmailConfirmed = true
                  }
                ); 
        }
    }
}