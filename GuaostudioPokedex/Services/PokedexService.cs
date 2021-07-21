using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuaostudioPokedex.Services
{
    public interface IPokedexService
    {
        Task<string> GetName(string name);
        Task<string> GetId(int id);
        Task<string> GetAllPokemon();
    }

    public class PokedexService : IPokedexService
    {
        private HttpClient _httpClient;

        public PokedexService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetName(string name)
        {
            string APIURL = $"{name}";
            var response = await _httpClient.GetAsync(APIURL);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetId(int id)
        {
            string APIURL = $"{id}";
            var response = await _httpClient.GetAsync(APIURL);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllPokemon()
        {
            string APIRUL = $"?limit=1118";
            var response = await _httpClient.GetAsync(APIRUL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
