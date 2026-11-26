using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace videojuegos
{
    public partial class pagina1 : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD() {
            String stringConexion = System.Environment.GetEnvironmentVariable("COURSEWORK_VIDEOGAMES_ODBC") ?? "DSN=coursework-local";
            try{
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lbContador.Text = "conexion exitosa";
                return conexion;
            }
            catch (Exception ex) {
                lbContador.Text = ex.StackTrace.ToString();
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
        }

        protected void btPagina2_Click(object sender, EventArgs e)
        {

        }
    }
}