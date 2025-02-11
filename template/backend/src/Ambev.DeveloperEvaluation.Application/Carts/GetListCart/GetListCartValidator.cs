using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetListCart
{
    public class GetListCartValidator : AbstractValidator<GetListCartCommand>
    {
        public GetListCartValidator()
        {
            RuleFor(r => r).NotEmpty().WithMessage("Something went wrong in Cart List!");
        }

    }
}
