using Microsoft.AspNetCore.Mvc;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetWeather(string location)
    {
        try
        {
            var weatherData = await _weatherService.GetWeatherAsync(location);
            return View("Index", weatherData);
        }
        catch (Exception)
        {
            ViewBag.ErrorMessage = "Unable to fetch weather data. Please try again later.";
            return View("Index");
        }
    }
}
