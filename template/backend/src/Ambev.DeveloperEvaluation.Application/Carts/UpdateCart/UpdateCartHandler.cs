using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartHandler : AbstractValidator<UpdateCartCommand>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public UpdateCartHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCartResult> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCartValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var cart = _mapper.Map<Cart>(request);

            var updatedCart = await _cartRepository.UpdateAsync(cart, cancellationToken);
            if (updatedCart == null)
                throw new KeyNotFoundException($"Cart with ID {request.Id} not found");

            var result = _mapper.Map<UpdateCartResult>(updatedCart);

            return result;
        }
    }
}
