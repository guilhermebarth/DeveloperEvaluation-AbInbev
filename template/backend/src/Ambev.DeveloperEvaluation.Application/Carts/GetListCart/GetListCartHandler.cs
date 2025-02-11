using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetListCart
{
    public class GetListCartHandler : IRequestHandler<GetListCartCommand, GetListCartResult>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        public GetListCartHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task<GetListCartResult> Handle(GetListCartCommand request, CancellationToken cancellationToken)
        {
            var validator = new GetListCartValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var listCarts = await _cartRepository.GetListCarts(cancellationToken);
            if (listCarts == null)
                throw new KeyNotFoundException($"Something wrong happened when trying to catch Cart List");

            return _mapper.Map<GetListCartResult>(listCarts);
        }
    }
}
