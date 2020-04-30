using Api.Web.Carros.Data;
using Api.Web.Carros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Web.Carros.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CarrosController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CarrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _context.Carros;
        }

        [HttpPost]
        public IActionResult Post(Carro carro)
        {
            if (carro != null)
            {
                _context.Carros.Add(carro);
                _context.SaveChanges();
                return Ok("Carro Adicionado na garagem!");
            }
            return BadRequest();

        }

        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var carro = _context.Carros.First(c => c.Id == id);

            if (carro != null)
            {
                _context.Carros.Remove(carro);
                _context.SaveChanges();
                return Ok("Carro Removido!");
            }
            return BadRequest("Carro nao existe");
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Carro dados)
        {
            var carro = _context.Carros.First(c => c.Id == id);

            if (carro != null)
            {
                carro.Modelo = String.IsNullOrEmpty(dados.Modelo) ? carro.Modelo : dados.Modelo;
                carro.Ano = (dados.Ano <= 0) ? carro.Ano : dados.Ano;
                carro.Marca = String.IsNullOrEmpty(dados.Marca) ? carro.Marca : dados.Marca;
                _context.Carros.Update(carro);
                _context.SaveChanges();
                return Ok(carro);
            }
            return BadRequest("Algo deu errado!");
        }

    }
}
