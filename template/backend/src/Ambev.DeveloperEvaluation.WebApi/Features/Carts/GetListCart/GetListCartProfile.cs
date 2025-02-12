using Ambev.DeveloperEvaluation.Application.Carts.GetListCart;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetListCart
{
    public class GetListCartProfile : Profile
    {
        public GetListCartProfile()
        {
            CreateMap<GetListCartRequest, GetListCartCommand>();
            CreateMap<GetListCartResult, GetListCartResponse>();
        }
    }
}
