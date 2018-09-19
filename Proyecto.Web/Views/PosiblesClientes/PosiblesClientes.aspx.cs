using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {

        public void limpiar()
        {
            txtIdentificacion.Text = "";
            txtEmpresa.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = ""; 
        }

        void getPosiblesClientes()
        {
            try
            {
                Controlador.PosiblesClientesController obPosiblesClientesController = new Controlador.PosiblesClientesController();
                DataSet dsConsulta = obPosiblesClientesController.GetConsultarPosiblesClientesController();

                if (dsConsulta.Tables[0].Rows.Count > 0) gvwDatos.DataSource = dsConsulta;

                else
                {
                    gvwDatos.DataSource = null;
                }

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '" + ex.Message + "!','error') </script>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getPosiblesClientes();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String Stmensaje = string.Empty;
                if (string.IsNullOrEmpty(txtIdentificacion.Text)) Stmensaje += "Ingrese identificacion";
               
                if (!string.IsNullOrEmpty(Stmensaje)) throw new Exception(Stmensaje.TrimEnd(','));

                Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                {
                    InIdentificacion = Convert.ToInt64(txtIdentificacion.Text),
                    stEmpresa = txtEmpresa.Text,
                    stPrimerNombre = txtPrimerNombre.Text,
                    stSegundoNombre = txtSegundoNombre.Text,
                    stPrimerApellido = txtPrimerApellido.Text,
                    stSegundoApellido = txtSegundoApellido.Text,
                    stDireccion = txtDireccion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text
                };
                Controlador.PosiblesClientesController obposiblesClientesController = new Controlador.PosiblesClientesController();
                if (string.IsNullOrEmpty(lblOpcion.Text)) lblOpcion.Text = "1";
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "Mensaje", "<script> swal('Exito','" + obposiblesClientesController.setAdministrarPosiblesClientesController(obclsPosiblesClientes,Convert.ToInt32(lblOpcion.Text)) + "','sucess') </script>");
                lblOpcion.Text = string.Empty;
                getPosiblesClientes();
                //limpiar();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '"+ ex.Message+"!','error') </script>");
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

            protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "2";
                    //accede a un control web dentro de un grid
                    txtIdentificacion.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text;
                    txtEmpresa.Text = string.IsNullOrEmpty(gvwDatos.Rows[inIndice].Cells[1].Text) ? string.Empty : gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtPrimerNombre.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtSegundoNombre.Text = string.IsNullOrEmpty(gvwDatos.Rows[inIndice].Cells[3].Text) ? string.Empty : gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtPrimerApellido.Text = gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtSegundoApellido.Text= gvwDatos.Rows[inIndice].Cells[5].Text;
                    txtDireccion.Text = gvwDatos.Rows[inIndice].Cells[6].Text;
                    txtTelefono.Text = gvwDatos.Rows[inIndice].Cells[7].Text;
                    txtCorreo.Text = gvwDatos.Rows[inIndice].Cells[8].Text;

                    //limpiar();
                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    lblOpcion.Text = "3";

                    Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                    {
                        InIdentificacion = Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text),
                        stEmpresa = string.Empty,
                        stPrimerNombre = string.Empty,
                        stSegundoNombre = string.Empty,
                        stPrimerApellido = string.Empty,
                        stSegundoApellido = string.Empty,
                        stDireccion = string.Empty,
                        stTelefono = string.Empty,
                        stCorreo = string.Empty
                    };
                    Controlador.PosiblesClientesController obposiblesClientesController = new Controlador.PosiblesClientesController();
                    
                    ClientScript.RegisterStartupScript(this.GetType().GetType(), "Mensaje", "<script> swal('Exito','" + obposiblesClientesController.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(lblOpcion.Text)) + "','success') </script>");
                    lblOpcion.Text = string.Empty;
                    getPosiblesClientes();
                    //limpiar();
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "Mensaje", "<script> alert('" + ex.Message + "') </script>");
            }
        }
    }
}