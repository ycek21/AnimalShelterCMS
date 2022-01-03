using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData
            (
                new Size
                {
                    Id = Guid.NewGuid(),
                    Value = "Bardzo mały"
                },

                new Size
                {
                    Id = Guid.NewGuid(),
                    Value = "Mały"
                },

                new Size
                {
                    Id = Guid.NewGuid(),
                    Value = "Duży"
                },

                 new Size
                 {
                     Id = Guid.NewGuid(),
                     Value = "Średni"
                 },

                 new Size
                 {
                     Id = Guid.NewGuid(),
                     Value = "Bardzo duży"
                 }
            );
        }
    }
}