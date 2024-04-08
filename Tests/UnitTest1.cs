using TestApiApp;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var weather = WeatherService.ProvideWeather();

        Assert.That(WeatherService.WeatherLength, Is.EqualTo(weather.Length));
    }
}