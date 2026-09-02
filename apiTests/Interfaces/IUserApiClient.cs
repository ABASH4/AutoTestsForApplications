using apiTests.DTO;
using Refit;

namespace apiTests.Interfaces;

[Headers("x-api-key: free_user_3HpEX8ByLfu8b1GKvLqXVpzLeVT")]
public interface IUserApiClient
{
    [Get("/users/{id}")]
    Task<UserResponseDto> GetUserAsync(int id);
    
    [Post("/users")]
    Task<CreateUserResponseDto> CreateUserAsync([Body] CreateUserRequestDto createUserRequestDto);
    
    [Put("/users/{id}")]
    Task<CreateUserResponseDto> PutUserAsync(int id, [Body] CreateUserRequestDto user);
    
    [Delete("/users/{id}")]
    Task<HttpResponseMessage> DeleteUserAsync(int id);
}