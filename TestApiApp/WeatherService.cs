namespace TestApiApp;

public static class WeatherService
{
    public static string[] ProvideWeather() =>
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public static int WeatherLength => ProvideWeather().Length;
}