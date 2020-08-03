using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Capa_Datos
{
    public class Modelo_FondoMonetarioInternacional: DbContext
    {
        public Modelo_FondoMonetarioInternacional() : base("name=bdFondoMonetarioInternacional")  
        {

        }
        public virtual DbSet<GestionPrestamo> GestionPrestamo{ get; set; }
        public virtual DbSet<CatIdioma> CatIdioma { get; set; }
        public virtual DbSet<CatPais> CatPais { get; set; }
    }
}
