using BlazorWeather.Models;
using System.Net.Http.Json;

namespace BlazorWeather.Services
{
    public class OpenWeatherService
    {
        private const string ApiKey = "629c2330ea97fc0152bdfc4100f0c0ac";
        private HttpClient _http;

        public OpenWeatherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<WeatherApiResponse> GetWeather(string name)
        {
            var response = await _http.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={ApiKey}&units=metric");
            var weather = await response.Content.ReadFromJsonAsync<WeatherApiResponse>();

            return weather;
        }
    }
}
