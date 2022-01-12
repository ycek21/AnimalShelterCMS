using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "0a747698-be88-4c59-93d4-3bbccdf43dfc",
                Name = "CommonUser",
                NormalizedName = "COMMON"
            },
            new IdentityRole
            {
                Id = "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                Name = "Administrator",
                NormalizedName = "ADMIN"
            }
            );
        }
    }
}