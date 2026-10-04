using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
}