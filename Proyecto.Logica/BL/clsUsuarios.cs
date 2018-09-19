using System;

using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{

    public class clsUsuarios
    {

        SqlConnection _sqlConnection = null;//comunicacion con la BD
        SqlCommand _sqlCommand = null;//me permite ejecutar comando sql
        SqlDataAdapter _sqlDataAdapter = null;//me permite adaptar conjunto de datos sql
        String stConexion = String.Empty;//Cadena de conexion

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        } 
        /// <summary>
        /// validar usuario
        /// </summary>
        /// <param name="obclsUsuarios">objeto usuario</param>
        /// <returns>Confirmacion</returns>
        public bool GetValidarUsuario(Models.clsUsuarios obclsUsuarios)
        {
            try
            {

                DataSet dsConsulta = new DataSet();

                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("stConsultarUsuario", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;


                _sqlCommand.Parameters.Add(new SqlParameter("@Email", obclsUsuarios.Email));
                _sqlCommand.Parameters.Add(new SqlParameter("@Codigo", obclsUsuarios.Codigo));

                _sqlCommand.ExecuteNonQuery();

                _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _sqlDataAdapter.Fill(dsConsulta);


                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}
