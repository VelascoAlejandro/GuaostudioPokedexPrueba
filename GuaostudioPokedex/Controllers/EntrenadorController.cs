using AutoMapper;
using GuaostudioPokedex.DTOs;
using GuaostudioPokedex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GuaostudioPokedex.Controllers
{
    [Route("Pokedex/Entrenador")]
    [ApiController]
    public class EntrenadorController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EntrenadorController(ILogger<PokemonController> logger,ApplicationDbContext context,IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<EntrenadorDTO>> Get(int Id)
        {
            var entrenador = await _context.Entrenadores.FirstOrDefaultAsync(x=>x.Id==Id);

            if (entrenador == null)
            {
                return NotFound();
            }

            return _mapper.Map<EntrenadorDTO>(entrenador);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EntrenadorCrearDTO entrenadorCrearDTO)
        {
            var entrenador = _mapper.Map<Entrenador>(entrenadorCrearDTO);
            _context.Add(entrenador);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult> Put(int Id,[FromBody] EntrenadorCrearDTO entrenadorCrearDTO)
        {
            var entrenador = await _context.Entrenadores.FirstOrDefaultAsync(x => x.Id == Id);

            if (entrenador == null)
            {
                return NotFound();
            }

            entrenador = _mapper.Map(entrenadorCrearDTO, entrenador);
            await _context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var existe = await _context.Entrenadores.AnyAsync(x => x.Id == Id);

            if (!existe)
            {
                return NotFound();
            }

            _context.Remove(new Entrenador() { Id = Id });
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
