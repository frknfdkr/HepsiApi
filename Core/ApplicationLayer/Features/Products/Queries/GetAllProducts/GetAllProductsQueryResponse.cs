using ApplicationLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        //bizim kullanıcıya gönderdiğimiz veriler

        public string Title { get; set; }
        public string Description { get; set; }       
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand { get; set; }

    }
}
