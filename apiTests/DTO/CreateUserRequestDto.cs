namespace apiTests.DTO;

public class CreateUserRequestDto
{
    public string Name { get; set; }
    public string Job { get; set; }
    
    public CreateUserRequestDto(string name, string job)
    {
        Name = name;
        Job = job;
    }
}
