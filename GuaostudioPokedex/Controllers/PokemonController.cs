using GuaostudioPokedex.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuaostudioPokedex.Controllers
{
    [Route("Pokedex/Pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        
        private readonly ILogger<PokemonController> _logger;
        private readonly IPokedexService _pokedexService;

        public PokemonController(ILogger<PokemonController> logger,IPokedexService pokedexService)
        {
            _logger = logger;
            _pokedexService = pokedexService;
        }

        [HttpGet("Name")]
        public async Task<string> Get(string name)
        {
            return await _pokedexService.GetName(name);
        }

        [HttpGet("AllPokemon")]
        public async Task<string> Get()
        {
            return await _pokedexService.GetAllPokemon();
        }

        [HttpGet("{id:int}")]
        public async Task<string> Get(int id)
        {
            return await _pokedexService.GetId(id);
        }
    }
}
