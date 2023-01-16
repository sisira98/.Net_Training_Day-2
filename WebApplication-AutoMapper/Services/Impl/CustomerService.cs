using WebApplication_AutoMapper.Data;
using WebApplication_AutoMapper.Domain;
using Microsoft.EntityFrameworkCore;
using WebApplication_AutoMapper.Data;
using WebApplication_AutoMapper.Domain;
using WebApplication_AutoMapper.Services;
using System.Threading.Tasks;

namespace WebApplication_AutoMapper.Services.Impl;

public class CustomerService : ICustomerService
{
    private readonly DataContext _dataContext;

    public CustomerService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<Customer>> GetCustomersAsync()
    {
        return await _dataContext.Customers.ToListAsync();
    }

    public async Task<Customer?> GetCustomerAsync(int customerId)
    {
        return await _dataContext.Customers.SingleOrDefaultAsync(c => c.CustomerId == customerId);
    }

    public async Task<bool> CreateCustomerAsync(Customer customer)
    {
        await _dataContext.Customers.AddAsync(customer);
        return await _dataContext.SaveChangesAsync() > 0;
    }
}