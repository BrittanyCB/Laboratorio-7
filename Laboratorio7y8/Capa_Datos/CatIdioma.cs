using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Datos
{
    public class CatIdioma
    {
        [Key]
        public int IdIdioma { get; set; }

        [StringLength(40)]
        public string NomIdioma { get; set; }
    }
}
