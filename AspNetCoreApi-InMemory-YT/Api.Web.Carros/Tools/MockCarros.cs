using Api.Web.Carros.Data;
using Api.Web.Carros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Web.Carros.Tools
{
    public class MockCarros
    {
        private readonly ApplicationDbContext _context;

        public MockCarros(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void AddCarrosIniciais()
        {
            List<Carro> Garagem = new List<Carro>
            {
                new Carro { Marca = "Chevrolet", Modelo = "Camaro SS", Ano = 2020, ImgLink = "https://www.autoo.com.br/fotos/2019/5/960_720/chevrolet_camaro_2020_1_06052019_12449_960_720.jpg"},
                new Carro { Marca = "Volkswagen", Modelo = "Jetta GLI", Ano = 2019, ImgLink = "https://cdn-motorshow-ssl.akamaized.net/wp-content/uploads/sites/2/2019/10/8_ms430_vw-jetta-gli1.jpg"},
                new Carro { Marca = "Ford", Modelo = "Mustang", Ano = 2014, ImgLink = "https://www.autoo.com.br/fotos/2013/960_640/ford_mustang_2014_ultimo_02_960_640.jpg"},
                new Carro { Marca = "Subaru", Modelo = "WRX STI", Ano = 2012, ImgLink = "https://media.caradvice.com.au/image/private/s--TbAecPhM--/v1541586291/c9bbfe0d4a3c453cf8dfbf5ae4b23c79.jpg"},
                new Carro { Marca = "Audi", Modelo = "A5", Ano = 2019, ImgLink = "https://fotos.jornaldocarro.estadao.com.br/uploads/2019/03/25183608/Audi-A5_Sportback-2017-1600-01-1160x771.jpg"}
            };

            _context.Carros.AddRange(Garagem);
            _context.SaveChanges();
        }
    }
}
