using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                Name = "Kalem 1",
                Stock = 20,
                Price = 100,
                CategoryId = 1,
            },
            new Product
            {
                
                Id = 2,
                CreatedDate = DateTime.Now,
                Name = "Kalem 2",
                Stock = 30,
                Price = 200,
                CategoryId = 1,
            },
            new Product
            {
                
                Id = 3,
                CreatedDate = DateTime.Now,
                Name = "Kalem 3",
                Stock = 600,
                Price = 60,
                CategoryId = 1,
            },
            new Product
            {
                
                Id = 4,
                CreatedDate = DateTime.Now,
                Name = "Kitap 1",
                Stock = 600,
                Price = 60,
                CategoryId = 2,
            },
            new Product
            {
                
                Id = 5,
                CreatedDate = DateTime.Now,
                Name = "Kitap 2",
                Stock = 700,
                Price = 500,
                CategoryId = 2,
            });
        }
    }
}
