using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class AspNetUserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "e643aedc-b67e-4ad2-9d84-7019ee5f4f21",
                    UserId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                }

            );
        }
    }
}


