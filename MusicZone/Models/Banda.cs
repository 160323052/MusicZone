using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicZone.Models
{
    public class Banda
    {
        [Required(ErrorMessage="Insira um nome válido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira Numero")]
        public int? NumeroElementos { get; set; }
        public string Genero { get; set; }
        public bool Top { get; set; }
    }
}
