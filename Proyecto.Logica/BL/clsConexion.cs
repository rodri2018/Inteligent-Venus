using System;
using System.Configuration;
using Proyecto.Logica.Models;

namespace Proyecto.Logica.BL
{
    public class clsConexion
    {
        

        /// <summary>
        /// Obtiene conexion BD
        /// </summary>
        /// <returns>Cadenas de conexion</returns>
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
