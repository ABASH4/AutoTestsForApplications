using System.Text.Json.Serialization;

namespace apiTests.DTO.UsersDTOs;

public record AddressDTO(
    [property: JsonPropertyName("street")] string Street,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("geo")] GeoDTO Geo
);