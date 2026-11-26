using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
namespace videojuegos
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        public OdbcConnection conectarBD()
        {
            String stringConexion = System.Environment.GetEnvironmentVariable("COURSEWORK_VIDEOGAMES_ODBC") ?? "DSN=coursework-local";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lbContador.Text = "conexion exitosa";
                return conexion;
            }
            catch (Exception ex)
            {
                lbContador.Text = ex.StackTrace.ToString();
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                String query = String.Format("SELECT nombre, edad, sexo FROM usuario WHERE claveU={0}", Session["claveUnica"]);
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txNombre.Text = rd.GetString(0);
                    txEdad.Text = rd.GetString(1);
                    txSexo.Text = rd.GetString(2);
                    rd.Close();
                }
                else
                    lbContador.Text = "error: no hay datos";
            }
            else
                lbContador.Text = "no se pudo conectar";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Pagina3.aspx");
        }
    }
}