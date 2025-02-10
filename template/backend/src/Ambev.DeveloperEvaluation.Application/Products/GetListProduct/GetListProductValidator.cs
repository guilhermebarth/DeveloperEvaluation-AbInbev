using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetListProduct
{
    public class GetListProductValidator : AbstractValidator<GetListProductCommand>
    {
        public GetListProductValidator()
        {
            RuleFor(r => r).NotEmpty().WithMessage("Something went wrong!");
        }
    }
}
