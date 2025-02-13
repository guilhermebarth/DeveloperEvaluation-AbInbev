using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetListCart
{
    public class GetListCartRequestValidator : AbstractValidator<GetListCartRequest>
    {
        public GetListCartRequestValidator()
        {
            RuleFor(r => r).NotEmpty();
        }
    }
}
