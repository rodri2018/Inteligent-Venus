using System;
using System.Data;
namespace Proyecto.Web.Controlador
{
    public class ProductosController
    {
        /// <summary>
        /// Obtiene Productos
        /// </summary>
        /// <returns>Data productos</returns>
        public DataSet GetConsultarProductosController()
        {
            try
            {
                Logica.BL.clsProductos obcclsProductos = new Logica.BL.clsProductos();
                return obcclsProductos.GetConsultarProductos();


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}