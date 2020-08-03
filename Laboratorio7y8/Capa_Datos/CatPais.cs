using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Datos
{
    public class CatPais
    {
        [Key]
        public int IdPais { get; set; }

        [StringLength(60)]
        public string NomPais { get; set; }
    }
}
