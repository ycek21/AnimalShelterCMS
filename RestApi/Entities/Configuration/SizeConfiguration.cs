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
                    Value = "Very small"
                },

                new Size
                {
                    Id = Guid.NewGuid(),
                    Value = "Small"
                },

                new Size
                {
                    Id = Guid.NewGuid(),
                    Value = "Big"
                },

                 new Size
                 {
                     Id = Guid.NewGuid(),
                     Value = "Medium"
                 },

                 new Size
                 {
                     Id = Guid.NewGuid(),
                     Value = "Very big"
                 }
            );
        }
    }
}