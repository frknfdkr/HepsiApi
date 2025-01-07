using ApplicationLayer.Dto;
using ApplicationLayer.Interfaces.AutoMapper;
using ApplicationLayer.Interfaces.UnitOfWorks;
using DomainLayer.Entities;
using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        //request ve response arasında köprü görevi görür
        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAllAsync(include:x=>x.Include(b=>b.Brand));

            var brand = _mapper.Map<BrandDto, Brand>(new Brand());

            var map = _mapper.Map<GetAllProductsQueryResponse, Product>(product);

            foreach (var item in map)
                item.Price -= (item.Price * item.Discount / 100);

            return map;
        }
    }
}
