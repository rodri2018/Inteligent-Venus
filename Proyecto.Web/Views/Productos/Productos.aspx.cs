using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
namespace Proyecto.Web.Views.Productos
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                { 
                    Controlador.ProductosController obproductosController = new Controlador.ProductosController();
                    DataSet dsConsulta = obproductosController.GetConsultarProductosController();

                    if(dsConsulta.Tables[0].Rows.Count > 0)
                    {
                        gvwDatos.DataSource = dsConsulta;
                    }
                    else
                    {
                        gvwDatos.DataSource = null;
                    }
                    gvwDatos.DataBind();
                }
                catch(Exception ex)
                {
                     ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '" + ex.Message + "!','error') </script>");
                }
            }
        }
    }
}