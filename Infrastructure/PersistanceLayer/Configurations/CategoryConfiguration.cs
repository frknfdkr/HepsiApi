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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        //{
        //    Category cat1 = new()
        //    {
        //        Id = 1,
        //        Name = "Elektrik",
        //        Priorty = 1,
        //        ParentId = 0,
        //        Status = true,
        //        CreatedDate = DateTime.Now,
        //    };
        //    Category cat2 = new()
        //    {
        //        Id = 2,
        //        Name = "Moda",
        //        Priorty = 2,
        //        ParentId = 0,
        //        Status = true,
        //        CreatedDate = DateTime.Now,
        //    };
        //    Category par1 = new()
        //    {asd
        //        Id = 3,
        //        Name = "Bilgisayar",
        //        Priorty = 1,
        //        ParentId = 1,
        //        Status = true,
        //        CreatedDate = DateTime.Now,
        //    };
        //    Category par2 = new()
        //    {
        //        Id = 4,
        //        Name = "Kadın",
        //        Priorty = 1,
        //        ParentId = 2,
        //        Status = true,
        //        CreatedDate = DateTime.Now,
        //    };

        //    builder.HasData(cat1, cat2, par1, par2);
        }
    }
}
