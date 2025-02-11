using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartValidator : AbstractValidator<GetCartCommand>
    {
        public GetCartValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage("Cart ID can't be empty");
        }
    }
}
