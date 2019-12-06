using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestASP.NETCORE.Models;

namespace TestASP.NETCORE.Services
{
    public interface IRepositorioPais
    {
        List<Pais> ObtenerTodos();
       
    }
}
