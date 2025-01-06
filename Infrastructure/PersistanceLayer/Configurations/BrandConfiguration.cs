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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            //builder.Property(x => x.Name).HasMaxLength(256);

            //Faker _faker = new("tr");

            //Brand brand1 = new()
            //{
            //    Id = 1,
            //    Name = _faker.Company.CompanyName(),
            //    CreatedDate = DateTime.Now,
            //    Status = false
            //};
            //Brand brand2 = new()
            //{
            //    Id = 2,
            //    Name = _faker.Company.CompanyName(),
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Brand brand3 = new()
            //{
            //    Id = 3,
            //    Name = _faker.Company.CompanyName(),
            //    CreatedDate = DateTime.Now,
            //    Status = false
            //};

            //builder.HasData(brand1, brand2, brand3);
        }
    }
}
