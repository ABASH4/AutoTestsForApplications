using System.Text.Json.Serialization;

namespace apiTests.DTO.UsersDTOs;

public record GeoDTO(
    [property: JsonPropertyName("lat")] double Lat,
    [property: JsonPropertyName("lng")] double Lng
);