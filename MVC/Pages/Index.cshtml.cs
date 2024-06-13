using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVC.Model;

namespace MVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WeatherService _weatherService;

        public WeatherData WeatherData { get; set; }

        public IndexModel(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost(string location)
        {
            WeatherData = (WeatherData)_weatherService.GetWeatherData(location);

            
            return Page();
        }
    }
}
