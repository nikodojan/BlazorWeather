using BlazorWeather.Models;
using Microsoft.JSInterop;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace BlazorWeather.Services
{
    public class OpenWeatherService
    {
        private const string ApiKey = "";
        private HttpClient _http;      

        public OpenWeatherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<WeatherApiResponse> GetWeatherByName(string name)
        {
            var response = await _http.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={ApiKey}&units=metric");
            var weather = await response.Content.ReadFromJsonAsync<WeatherApiResponse>();

            return weather;
        }

        public async Task<WeatherApiResponse> GetWeatherByCoords(string lat, string lon)
{
            var response = await _http.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={ApiKey}&units=metric");
            var weather = await response.Content.ReadFromJsonAsync<WeatherApiResponse>();

            return weather;
        }
    }
}
