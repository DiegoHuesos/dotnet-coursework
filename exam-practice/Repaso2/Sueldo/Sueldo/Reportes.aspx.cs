using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sueldo
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected OdbcConnection agregarConexion()
        {
            try
            {
                OdbcConnection conexion = new OdbcConnection(System.Environment.GetEnvironmentVariable("COURSEWORK_PAYROLL_ODBC") ?? "DSN=coursework-local");
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
            protected void Page_Load(object sender, EventArgs e)
            {
                OdbcConnection con = agregarConexion();
                if (con != null)
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM informacion$", con);
                    OdbcDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();
                }
            }
        
    }
}