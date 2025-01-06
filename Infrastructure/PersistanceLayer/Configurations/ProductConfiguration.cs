using Bogus;
using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceLayer.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Faker _faker = new("tr");

            //Product _por1 = new()
            //{
            //    Id = 1,
            //    Title = _faker.Commerce.ProductName(),
            //    Description = _faker.Commerce.ProductDescription(),
            //    BrandId = 1,
            //    Discount = _faker.Random.Decimal(0, 30),
            //    Price = _faker.Finance.Amount(500, 1000),
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Product _por2 = new()
            //{
            //    Id = 2,
            //    Title = _faker.Commerce.ProductName(),
            //    Description = _faker.Commerce.ProductDescription(),
            //    BrandId = 3,
            //    Discount = _faker.Random.Decimal(0, 30),
            //    Price = _faker.Finance.Amount(500, 1000),
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Product _por3 = new()
            //{
            //    Id = 3,
            //    Title = _faker.Commerce.ProductName(),
            //    Description = _faker.Commerce.ProductDescription(),
            //    BrandId = 4,
            //    Discount = _faker.Random.Decimal(0, 30),
            //    Price = _faker.Finance.Amount(500, 1000),
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};

            //builder.HasData(_por1, _por2, _por3);
        }
    }
}
