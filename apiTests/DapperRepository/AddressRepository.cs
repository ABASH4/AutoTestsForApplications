using apiTests.DTO.DapperDTOs;
using apiTests.Interfaces.DapperInterfaces;
using Dapper;
using Microsoft.Data.Sqlite;

namespace apiTests.DapperRepository;

public class AddressRepository : IAddressRepository
{
    private readonly string connectionString;
    
    public AddressRepository(string connection)
    {
        connectionString = connection;
    }
    
    public async Task<IEnumerable<AddressDTO>> GetAllAddressesAsync()
    {
        using var db = new SqliteConnection(connectionString);
        var addresses = await db.QueryAsync<AddressDTO>("SELECT * FROM Addresses");
        return addresses;
    }
    
    public async Task<AddressDTO> GetAddressByUserId(int userId)
    {
        using var db = new SqliteConnection(connectionString);
        var address = await db.QueryFirstOrDefaultAsync<AddressDTO>("SELECT * FROM Addresses where UserId = @userId", new { userId });
        return address;
    }
}