using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            //var existingUser = await _productRepository.CreateAsync(command, cancellationToken);
            //if (existingUser != null)
            //    throw new InvalidOperationException($"User with email {command.Email} already exists");

            var roduct = _mapper.Map<Product>(command);

            var createdProduct = await _productRepository.CreateAsync(roduct, cancellationToken);
            var result = _mapper.Map<CreateProductResult>(createdProduct);
            return result;
        }
    }
}
