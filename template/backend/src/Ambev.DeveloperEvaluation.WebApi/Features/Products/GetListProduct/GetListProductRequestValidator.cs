using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetListProduct
{
    public class GetListProductRequestValidator : AbstractValidator<GetListProductRequest>
    {
        public GetListProductRequestValidator()
        {
            RuleFor(r => r).NotEmpty();
        }
    }
}
