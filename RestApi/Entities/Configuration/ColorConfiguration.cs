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
                    Value = "Black"
                },

                new Color
                {
                    Id = Guid.NewGuid(),
                    Value = "White"
                },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Mixed"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Red"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Tricolor"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Blue"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Grey"
                 },

                 new Color
                 {
                     Id = Guid.NewGuid(),
                     Value = "Fawn"
                 },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Cream"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Gold"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Yellow"
                  },

                  new Color
                  {
                      Id = Guid.NewGuid(),
                      Value = "Brown"
                  }
            );
        }
    }
}