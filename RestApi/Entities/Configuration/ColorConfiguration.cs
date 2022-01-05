using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {

        // https://pl.wikipedia.org/wiki/Umaszczenie
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData
            (
                new Color
                {
                    Id = Guid.NewGuid(),
                    Value = "Czarny"
                },

                new Color
                {
                    Id = Guid.NewGuid(),
                    Value = "Biały"
                },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Mieszany"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Rudy"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Tricolor"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Niebieski"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Pstrokaty"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Podpalane"
                 },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Marengo"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Śniady"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Wilczy"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Dzicze"
                  }
            );
        }
    }
}