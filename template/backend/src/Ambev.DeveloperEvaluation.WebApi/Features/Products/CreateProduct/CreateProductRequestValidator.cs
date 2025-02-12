using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {

        public CreateProductRequestValidator()
        {
            RuleFor(r => r.Category).NotEmpty();
        }
    }
}
