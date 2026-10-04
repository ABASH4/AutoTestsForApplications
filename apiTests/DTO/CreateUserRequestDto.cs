using System.Text.Json.Serialization;

namespace apiTests.DTO;

public class CreateUserRequestDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("job")]
    public string Job { get; set; }

    public CreateUserRequestDto(string name, string job)
    {
        Name = name;
        Job = job;
    }
}