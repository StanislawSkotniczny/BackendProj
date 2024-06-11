using LabWebApi.Core.Entities;

namespace LabWebApi.Infrastructure.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
    }
}