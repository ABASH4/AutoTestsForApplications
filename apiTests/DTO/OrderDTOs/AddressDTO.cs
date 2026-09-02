using System.Text.Json.Serialization;

namespace apiTests.DTO.OrderDTOs;

public record AddressDTO(
    [property: JsonPropertyName("country")]
    string Country,
    [property: JsonPropertyName("city")]
    string City,
    [property: JsonPropertyName("street")]
    string Street,
    [property: JsonPropertyName("zip")]
    string Zip
);