using System;


namespace Proyecto.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //if(IsPostBack)
            //   ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '" + ex.Message + "!,'error') </script>");
           // ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Good job', 'You clicked the button!', 'error') </script>");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String Stmensaje = string.Empty;
                if (string.IsNullOrEmpty(TxtEmail.Text)) Stmensaje += "ingrese email,";
                if (string.IsNullOrEmpty(TxtPassword.Text)) Stmensaje += "Ingrese contraseña,";
                if (!string.IsNullOrEmpty(Stmensaje)) throw new Exception(Stmensaje.TrimEnd(','));
                //DEFINO OBJETO CON PROPIEDADES
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    
                    Email = TxtEmail.Text,
                    Codigo = int.Parse(TxtPassword.Text)

                    
                };
                //INTANCION CONTROLADOR
                Controlador.LoginController obLoginController = new Controlador.LoginController();
                bool blBandera = obLoginController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                    Response.Redirect("../Index/Index.aspx");
                else
                    throw new Exception("Usuario o Password incorrectos");

            }catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType().GetType(), "mensaje", "<script>swal('Error', '"+ ex.Message+"!','error') </script>");
            }
        }
    }
}