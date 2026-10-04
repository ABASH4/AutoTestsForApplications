using System.Text.Json.Serialization;

namespace apiTests.DTO.UsersDTOs;

public record RootDTO(
    [property: JsonPropertyName("data")] IReadOnlyList<UserDTO> Data
);