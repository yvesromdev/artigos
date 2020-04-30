using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Web.Carros.Models
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string ImgLink { get; set; }

        public Carro()
        {
            Id = Guid.NewGuid();
        }
    }
}
