using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IAddressRepository
{
    Task<IEnumerable<AddressDTO>> GetAllAddressesAsync();
    Task<AddressDTO> GetAddressByUserId(int userId);
}