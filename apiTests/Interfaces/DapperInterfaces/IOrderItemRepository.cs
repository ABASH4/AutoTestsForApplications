using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IOrderItemRepository
{
    Task<IEnumerable<OrderItemDTO>> GetAllOrderItemsAsync();
    Task<IEnumerable<OrderItemDTO>> GetOrderItemsByOrderIdAsync(int orderId);
    Task<IEnumerable<OrderItemDTO>> GetOrderItemsByProductIdAsync(int productId);
}