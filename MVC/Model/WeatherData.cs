namespace MVC.Model
{
    public class WeatherData
    {
        public string Name { get; set; }
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public Wind Wind { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
    }

}
