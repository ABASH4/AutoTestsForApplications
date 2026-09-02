using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using NUnit.Framework;
using apiTests.DTO;
using Refit;

namespace apiTests;

public class Tests
{
    public static HttpClient client;
    
    [OneTimeSetUp]
    public void Setup()
    {
        client = new HttpClient()
        {
            BaseAddress = new Uri("https://reqres.in/api/")
        };
        client.DefaultRequestHeaders.Add("x-api-key", "free_user_3HpEX8ByLfu8b1GKvLqXVpzLeVT");

    }
//free_user_3HpEX8ByLfu8b1GKvLqXVpzLeVT
//GET reqres.in/api/users?page=2

    [Test]
    public async Task Test1()
    {
        using HttpResponseMessage response = await client.GetAsync("users/2");
        response.EnsureSuccessStatusCode();
    }

    [Test]
    public async Task Test2()
    {
        using HttpResponseMessage response = await client.GetAsync("users/2");
        string jsonGet = await response.Content.ReadAsStringAsync();
        UserResponseDto userResponse = JsonSerializer.Deserialize<UserResponseDto>(jsonGet);
        UserDataDto user = userResponse.Data;
        
    }
    
    [Test]
    public async Task Test3()
    {
        CreateUserRequestDto user = new CreateUserRequestDto("Aleksei", "QA");

        using HttpResponseMessage response = await client.PostAsJsonAsync("users", user);
        string jsonGet = await response.Content.ReadAsStringAsync();
        CreateUserResponseDto createUserResponseDto = JsonSerializer.Deserialize<CreateUserResponseDto>(jsonGet);
        response.EnsureSuccessStatusCode();
    }
    
    [Test]
    public async Task Test4()
    {
        CreateUserRequestDto user = new CreateUserRequestDto("Aleksei", "Dvornick");

        using HttpResponseMessage response = await client.PutAsJsonAsync("users/2", user);
        response.EnsureSuccessStatusCode();
    }
    
    [Test]
    public async Task Test5()
    {
        using HttpResponseMessage response = await client.DeleteAsync("users/2");
        response.EnsureSuccessStatusCode();
    }
    

    [OneTimeTearDown]
    public void TearDown()
    {
        client.Dispose();
    }

}


