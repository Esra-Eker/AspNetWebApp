using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
                {
                    Id = 1,
                    Name = "Kalem"
                },
                new Category
                {
                    Id = 2,
                    Name = "Kitap"
                },
                new Category
                {
                    Id = 3,
                    Name = "Defter"
                });
        }
    }
}
