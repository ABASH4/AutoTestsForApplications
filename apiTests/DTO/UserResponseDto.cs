using System.Text.Json.Serialization;

namespace apiTests.DTO;

public class UserResponseDto
{
    [JsonPropertyName("data")]
    public UserDataDto Data { get; set; } 
}