using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Laboratorio7y8
{
    public partial class Pagina_Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarGrid();
            }
        }
        public void cargarGrid()
        {
            using (Modelo_FondoMonetarioInternacional contextoBD = new Modelo_FondoMonetarioInternacional())
            {
                 gridDatos.DataSource = contextoBD.GestionPrestamo.ToList();
                 gridDatos.DataBind();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (Modelo_FondoMonetarioInternacional contextoBD = new Modelo_FondoMonetarioInternacional())
            {
                GestionPrestamo objPrestamo = new GestionPrestamo();
                objPrestamo.Pais = Convert.ToInt32("NomPais");
                objPrestamo.Habitantes =Convert.ToInt32("@Habitantes");
                objPrestamo.Idioma = Convert.ToInt32("NomIdioma");
                objPrestamo.PIB = Convert.ToInt32("@PIB");
                objPrestamo.Superficie = Convert.ToInt32("@Superficie");
                objPrestamo.RiesgoSeguridad=Convert.ToChar("@RiesgoSeguridad");
                objPrestamo.SujetoPrestamo = Convert.ToBoolean("@SujetoPrestamo");
                contextoBD.GestionPrestamo.Add(objPrestamo);
                contextoBD.SaveChanges(); 
                cargarGrid();
            }

        }
       protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (Modelo_FondoMonetarioInternacional contextoBD = new Modelo_FondoMonetarioInternacional())
            {

                GestionPrestamo aux = contextoBD.GestionPrestamo.Where(x => x.Pais == 1025487).FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                aux.Pais= Convert.ToInt32("NomPais");
                aux.Habitantes= Convert.ToInt32("@Habitantes");
                aux.Idioma= Convert.ToInt32("NomIdioma");
                aux.PIB= Convert.ToInt32("@PIB");
                aux.Superficie= Convert.ToInt32("@Superficie");
                aux.RiesgoSeguridad= Convert.ToChar("@RiesgoSeguridad");
                aux.SujetoPrestamo= Convert.ToBoolean("@SujetoPrestamo");

                contextoBD.SaveChanges();
                cargarGrid();

            }

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (Modelo_FondoMonetarioInternacional contextoBD = new Modelo_FondoMonetarioInternacional())
            {

                GestionPrestamo aux = contextoBD.GestionPrestamo.Where(x => x.Pais == 10245871).FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                contextoBD.GestionPrestamo.Remove(aux);
                contextoBD.SaveChanges();
                cargarGrid();

            }

        }
    }
}