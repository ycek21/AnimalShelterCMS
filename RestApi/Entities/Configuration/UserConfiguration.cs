using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = "1",
                    Email = "animal.shelter@gmail.com",
                    Name = "Admin",
                    Surname = "Super",
                    PasswordHash = "xd",
                    IsAdmin = true,
                    DateOfBirth = DateTime.Parse("2000-01-01"),
                }
            );
        }
    }
}