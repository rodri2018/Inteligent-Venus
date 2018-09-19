using System;
using System.Data;

namespace Proyecto.Web.Controlador
{
    public class PosiblesClientesController
    {
        //Obtiene nuestors posibles clientes - Retorna Data posibles clientes
        public DataSet GetConsultarPosiblesClientesController()
        {
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.GetConsultarPosiblesClientes();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Admisnistra posibles clientes
        public string setAdministrarPosiblesClientesController(Logica.Models.clsPosiblesClientes obclsPosiblesClientesModels, int inOpcion)
        {
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.SetAdministrarPosiblesClientes(obclsPosiblesClientesModels, inOpcion);
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}