using Refit;
using apiTests.DTO;
using apiTests.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace apiTests;

public class RefitTests
{
    private IUserApiClient _client;

    [OneTimeSetUp]
    public void Setup()
    {
        var services = new ServiceCollection();
        services.AddRefitClient<IUserApiClient>()
            .ConfigureHttpClient(c => { c.BaseAddress = new Uri("https://reqres.in/api"); });
        var provider = services.BuildServiceProvider();
        _client = provider.GetRequiredService<IUserApiClient>();
    }

    [Test]
    public async Task Test1()
    {
        var result = await _client.GetUserAsync(2);
        Assert.Multiple((() =>
                {
                    Assert.That(result.Data.Id, Is.EqualTo(2));
                    Assert.That(result.Data.Email, Is.Not.Null);
                }
            ));
    }

    [Test]
    public async Task Test2()
    {
        CreateUserRequestDto userRequestDto = new CreateUserRequestDto("Bashmucho", "Dvornick");
        var response = await _client.CreateUserAsync(userRequestDto);
        Assert.That(response.Name, Is.EqualTo("Bashmucho"));
    }
    
    [Test]
    public async Task Test3()
    {
        var updateUser = new CreateUserRequestDto("Bashmucho", "Dvornick");
        var response = await _client.PutUserAsync(2, updateUser);
        Assert.That(response.Job, Is.EqualTo("Dvornick"));
    }
    
    [Test]
    public async Task Test4()
    {
        var response = await _client.DeleteUserAsync(2);
        Assert.That(response.IsSuccessStatusCode, Is.True);
    }
}

