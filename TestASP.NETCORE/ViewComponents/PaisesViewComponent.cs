using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestASP.NETCORE.Services;

namespace TestASP.NETCORE.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public PaisesViewComponent(IRepositorioPais repositorioPais)
        {
            RepositorioPais = repositorioPais;
        }

        public IRepositorioPais RepositorioPais { get; }

        public IViewComponentResult Invoke()
        {
            var paises = RepositorioPais.ObtenerTodos();
            return View(paises);
        }
    }
}
