using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IUserRepository
{
    Task<IEnumerable<UserDTO>> GetAllAsync();
    Task<UserDTO> GetByIdAsync(int id);
    Task<UserDTO> GetUserByFirstAndLastName(string firstName, string lastName);
}