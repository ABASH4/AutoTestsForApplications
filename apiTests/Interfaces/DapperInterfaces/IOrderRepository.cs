using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IOrderRepository
{
    Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
    Task<OrderDTO> GetOrderByIdAsync(int id);
    Task<IEnumerable<OrderDTO>> GetOrdersByUserIdAsync(int userId);
}