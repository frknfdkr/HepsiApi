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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            //Faker _faker = new("tr");

            //Detail _det1 = new()
            //{
            //    Id = 1,
            //    Title = _faker.Lorem.Sentence(1),
            //    Description = _faker.Lorem.Sentence(1),
            //    CategoryId = 1,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Detail _det2 = new()
            //{
            //    Id = 2,
            //    Title = _faker.Lorem.Sentence(2),
            //    Description = _faker.Lorem.Sentence(2),
            //    CategoryId = 3,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Detail _det3 = new()
            //{
            //    Id = 3,
            //    Title = _faker.Lorem.Sentence(3),
            //    Description = _faker.Lorem.Sentence(3),
            //    CategoryId = 4,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //};
            //Detail _det4 = new()
            //{
            //    Id = 4,
            //    Title = _faker.Lorem.Sentence(4),
            //    Description = _faker.Lorem.Sentence(4),
            //    CategoryId = 2,
            //    CreatedDate = DateTime.Now,
            //    Status = false
            //};

            //builder.HasData(_det1, _det2, _det3, _det4);
        }
    }
}
