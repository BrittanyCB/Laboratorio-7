using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Datos
{
    public class GestionPrestamo
    {
        [Key]
        public int Pais { get; set; }
        public int Habitantes { get; set; }
        public int Idioma { get; set; }
        public int PIB { get; set; }
        public int Superficie { get; set; }
        public char RiesgoSeguridad { get; set; }
        public bool SujetoPrestamo { get; set; }

    }
}
