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

        public void Configure(EntityTypeBuilder<Detail> builder) { }
      

        //public void Configure(EntityTypeBuilder<Detail> builder)
        //{
           
        //}
    }
}
