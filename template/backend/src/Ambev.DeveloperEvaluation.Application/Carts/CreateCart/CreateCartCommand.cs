using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartCommand : IRequest<CreateCartResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public List<BoughtProducts> Products { get; set; }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateCartValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
