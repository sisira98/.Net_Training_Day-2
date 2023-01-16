using WebApplication_AutoMapper.Domain;
using System.Threading.Tasks;
namespace WebApplication_AutoMapper.Services
{
    public interface IOrderService
    {
        Task<Order?> GetOrderAsync(int orderId);
        Task<bool> CreateOrderAsync(Order order);
    }
}
