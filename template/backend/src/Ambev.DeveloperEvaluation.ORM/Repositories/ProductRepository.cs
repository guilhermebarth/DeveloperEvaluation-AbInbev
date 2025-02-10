using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DeveloperSalesContext _context;
        public ProductRepository(DeveloperSalesContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default)
        {
            await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }

        public async Task<List<Product>> GetListProducts(CancellationToken cancellationToken = default)
        {
            return await _context.Products.ToListAsync(cancellationToken);
        }

        public async Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Products.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        public async Task<Product?> UpdateAsync(Product product, CancellationToken cancellationToken = default)
        {
            var dbProduct = await GetByIdAsync(product.Id, cancellationToken);

            if (dbProduct == null)
            {
                return null;
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var product = await GetByIdAsync(id, cancellationToken);
            if (product == null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
