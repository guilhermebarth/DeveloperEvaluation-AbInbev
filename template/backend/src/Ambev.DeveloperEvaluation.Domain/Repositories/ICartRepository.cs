using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICartRepository
    {
        Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken = default);
        Task<List<Cart>> GetListCarts(CancellationToken cancellationToken = default);
        Task<Cart?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<Cart?> UpdateAsync(Cart product, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
