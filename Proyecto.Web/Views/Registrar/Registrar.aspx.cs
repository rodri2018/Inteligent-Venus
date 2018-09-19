using System;


namespace Proyecto.Web.Views.Registrar
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String Stmensaje = string.Empty;
                if (string.IsNullOrEmpty(TxtNombre.Text)) Stmensaje += "ingrese Nombre,";
                if (string.IsNullOrEmpty(TxtApellido.Text)) Stmensaje += "Ingrese Apellido,";
                if (string.IsNullOrEmpty(TxtIngEmail.Text)) Stmensaje += "Ingrese Email,";
                if (string.IsNullOrEmpty(TxtIngPassword.Text)) Stmensaje += "ingrese Contraseña,";
                if (string.IsNullOrEmpty(txtConfPassword.Text)) Stmensaje += "ingrese Confirmacion de contraseña,";
                if (TxtIngPassword.Text.Equals(txtConfPassword))
                {

                }
                else { Stmensaje += "no son iguales las constraseñas"; }
                if (!string.IsNullOrEmpty(Stmensaje)) throw new Exception(Stmensaje.TrimEnd(','));
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '" + ex.Message + "!','error') </script>");
            }
        }
    }
}