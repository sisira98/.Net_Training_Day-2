using Microsoft.EntityFrameworkCore;
using WebApplication_AutoMapper.Data;
using WebApplication_AutoMapper.Domain;
using WebApplication_AutoMapper.Services;
using System.Threading.Tasks;

namespace WebApplication_AutoMapper.Services.Impl;

public class ProductService : IProductService
{
    private readonly DataContext _dataContext;

    public ProductService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> CreateProductAsync(Product product)
    {
        await _dataContext.Products.AddAsync(product);
        var createdRowCount = await _dataContext.SaveChangesAsync();
        return createdRowCount > 0;
    }

    public async Task<Product?> GetProductAsync(int productId)
    {
        return await _dataContext.Products.SingleOrDefaultAsync(s => s.ProductId == productId);
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _dataContext.Products.ToListAsync();
    }
}