using Ambev.DeveloperEvaluation.Application.Products.GetListProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetListProduct
{
    public class GetListProductProfile : Profile
    {
        public GetListProductProfile()
        {
            CreateMap<GetListProductRequest, GetListProductCommand>();
            CreateMap<GetListProductResult, GetListProductResponse>();
        }
    }
}
