using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class ConfigConfiguration : IEntityTypeConfiguration<Config>
    {
        public void Configure(EntityTypeBuilder<Config> builder)
        {
            builder.HasData(
                new Config
                {
                    Key = "City",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "Street",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "HouseNumber",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "Postcode",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                }, new Config
                {
                    Key = "AccountNumber",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                 new Config
                 {
                     Key = "Description",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 },
                 new Config
                 {
                     Key = "Name",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 },
                 new Config
                 {
                     Key = "Country",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 }
            );
        }
    }
}