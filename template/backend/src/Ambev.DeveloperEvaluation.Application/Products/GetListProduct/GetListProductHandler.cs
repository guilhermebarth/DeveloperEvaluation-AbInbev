using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetListProduct
{
    public class GetListProductHandler : IRequestHandler<GetListProductCommand, GetListProductResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public GetListProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _repository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetListProductResult> Handle(GetListProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new GetListProductValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var listProducts = await _repository.GetListProducts(cancellationToken);
            if (listProducts == null)
                throw new KeyNotFoundException($"Something wrong happened when trying to catch Product List");

            return _mapper.Map<GetListProductResult>(listProducts);
        }
    }
}
