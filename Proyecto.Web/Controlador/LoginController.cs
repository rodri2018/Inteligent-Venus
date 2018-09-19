using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Web.Controlador
{
    public class LoginController
    {
        /// <summary>
        /// valida usuario
        /// </summary>
        /// <param name="oblclsUsuarios">Objeto usuario</param>
        /// <returns>confirmacion</returns>
        public bool getValidarUsuarioController(Logica.Models.clsUsuarios oblclsUsuarios)
        {
            try
            {
                Logica.BL.clsUsuarios obclsUsuario = new Logica.BL.clsUsuarios();
                return obclsUsuario.GetValidarUsuario(oblclsUsuarios);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}