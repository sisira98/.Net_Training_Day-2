using WebApplication_AutoMapper.Domain;

namespace WebApplication_AutoMapper.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<Customer?> GetCustomerAsync(int customerId);
        Task<bool> CreateCustomerAsync(Customer customer);
    }
}
