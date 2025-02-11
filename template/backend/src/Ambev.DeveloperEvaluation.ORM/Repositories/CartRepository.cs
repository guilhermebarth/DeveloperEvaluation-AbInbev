using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DeveloperSalesContext _context;
        public CartRepository(DeveloperSalesContext context)
        {
            _context = context;
        }

        public async Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken = default)
        {
            await _context.Cart.AddAsync(cart, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return cart;
        }

        public async Task<List<Cart>> GetListCarts(CancellationToken cancellationToken = default)
        {
            return await _context.Cart.ToListAsync(cancellationToken);
        }

        public async Task<Cart?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Cart.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        public async Task<Cart?> UpdateAsync(Cart cart, CancellationToken cancellationToken = default)
        {
            var dbCart = await GetByIdAsync(cart.Id, cancellationToken);

            if (dbCart == null)
            {
                return null;
            }

            _context.Cart.Update(cart);
            await _context.SaveChangesAsync(cancellationToken);

            return cart;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var cart = await GetByIdAsync(id, cancellationToken);
            if (cart == null)
                return false;

            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
