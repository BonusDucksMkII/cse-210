using System.ComponentModel;

public class Gathering : Event
{
    public string WeatherForecast;
    private string _weatherForecast;

    public Gathering(string title, string desc, DateTime date, string time, string address, string weather) : base(title, desc, date, time, address)
    {
        WeatherForecast = weather;
        _weatherForecast = WeatherForecast;
    }

    public string GetWeather()
    { return _weatherForecast; }

    public void SetWeather(string weather)
    {
        WeatherForecast = weather;
        _weatherForecast = WeatherForecast;
    }
    public override string FullDetails()
    {
        return $"{Title} - {Desc}\n{Date.ToShortDateString()} - {Time}\n{Address}\nWeather Forecast: {WeatherForecast}";
    }
}