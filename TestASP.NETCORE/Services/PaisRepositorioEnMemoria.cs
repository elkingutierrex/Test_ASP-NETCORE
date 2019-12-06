using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestASP.NETCORE.Models;

namespace TestASP.NETCORE.Services
{
    public class PaisRepositorioEnMemoria : IRepositorioPais
    {

        public List<Pais> ObtenerTodos()
        {
            List<Pais> Paises = new List<Pais> ()
            {   
                new Pais("Republica Dominicana")
            };
            return Paises;
        }
    }
}
