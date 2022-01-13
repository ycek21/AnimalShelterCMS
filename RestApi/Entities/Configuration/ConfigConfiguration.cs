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
                    Key = "Miasto",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "Ulica",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "NumerDomu",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                new Config
                {
                    Key = "KodPocztowy",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                }, new Config
                {
                    Key = "NumerKonta",
                    Value = "",
                    ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                },
                 new Config
                 {
                     Key = "Opis",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 },
                 new Config
                 {
                     Key = "Nazwa",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 },
                 new Config
                 {
                     Key = "Kraj",
                     Value = "",
                     ModifiedBy = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7"

                 }
            );
        }
    }
}