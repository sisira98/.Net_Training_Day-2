using WebApplication_AutoMapper.Domain;

namespace WebApplication_AutoMapper.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductAsync(int productId);
        Task<bool> CreateProductAsync(Product product);
    }
}
