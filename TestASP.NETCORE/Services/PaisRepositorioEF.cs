using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestASP.NETCORE.Data;
using TestASP.NETCORE.Models;

namespace TestASP.NETCORE.Services
{
    public class PaisRepositorioEF : IRepositorioPais
    {
        public PaisRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}
