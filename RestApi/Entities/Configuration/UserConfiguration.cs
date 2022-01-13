using System;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admin = new User
            {
                Id = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                Email = "admin.animalshelter@gmail.com",
                Name = "Admin",
                Surname = "Admin",
                UserName = "admin.animalshelter@gmail.com",
                NormalizedUserName = "admin.animalshelter@gmail.com".ToUpper(),
                NormalizedEmail = "admin.animalshelter@gmail.com".ToUpper(),
                DateOfBirth = DateTime.Parse("2000-01-01"),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            admin.PasswordHash = PasswordGenerate(admin);

            builder.HasData(admin);

        }

        private string PasswordGenerate(User user)
        {
            var passHash = new PasswordHasher<User>();
            return passHash.HashPassword(user, "SecretPassword");
        }
    }

}