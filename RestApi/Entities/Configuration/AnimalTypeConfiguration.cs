using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class AnimalTypeConfiguration : IEntityTypeConfiguration<AnimalType>
    {
        public void Configure(EntityTypeBuilder<AnimalType> builder)
        {
            builder.HasData
            (
                new AnimalType
                {
                    Id = Guid.NewGuid(),
                    Value = "Dog"
                },

                new AnimalType
                {
                    Id = Guid.NewGuid(),
                    Value = "Cat"
                }
            );
        }
    }
}