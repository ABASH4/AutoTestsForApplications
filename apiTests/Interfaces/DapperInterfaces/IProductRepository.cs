using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IProductRepository
{
    Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    Task<ProductDTO> GetProductByIdAsync(int id);
    Task<IEnumerable<ProductDTO>> GetProductsByCategoryId(int categoryId);
}