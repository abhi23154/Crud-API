using MVC.Model;
using Newtonsoft.Json;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "5c3b23c622c945be901559757ecf9cb2"; 
    private readonly string _baseUrl = "http://api.openweathermap.org/data/2.5/weather";

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherData> GetWeatherAsync(string location)
    {
        var url = $"{_baseUrl}?q={location}&appid={_apiKey}&units=metric"; 

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

        return weatherData;
    }

    internal WeatherData GetWeatherData(string location)
    {
        throw new NotImplementedException();
    }
}
