using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestASP.NETCORE.Models
{
    public class Pais
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
    }
}
