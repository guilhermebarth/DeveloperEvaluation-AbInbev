using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct
{
    public class GetProductRequestValidator : AbstractValidator<GetProductRequest>
    {
        public GetProductRequestValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage("Product ID shouldn't be empty");
        }
    }
}
