using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings
{
    public class CreateCartRequestProfile : Profile
    {
        public CreateCartRequestProfile()
        {
            CreateMap<CreateProductRequest, CreateProductCommand>();
        }
    }
}
