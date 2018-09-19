using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsProductos
    {
        SqlConnection _sqlConnection = null;//comunicacion con la BD
        SqlCommand _sqlCommand = null;//me permite ejecutar comando sql
        SqlDataAdapter _sqlDataAdapter = null;//me permite adaptar conjunto de datos sql
        String stConexion = String.Empty;//Cadena de conexion

        SqlParameter _sqlParameter = null;

        public clsProductos()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        /// <summary>
        /// Consulta Productos
        /// </summary>
        /// <returns>Registros de Productos</returns>
        public DataSet GetConsultarProductos()
        {
            try
            {

                DataSet dsConsulta = new DataSet();

                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("stConsultaProductos", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;



                _sqlCommand.ExecuteNonQuery();

                _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
               
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
        public DataSet SetAdministrarProductos(Models.clsProductos obproductos, int opcion)
        {
            try
            {
                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("spadministrarProductos", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@Codigo",obproductos.lnCodigo));
                _sqlCommand.Parameters.Add(new SqlParameter("@Nom_prod",obproductos.lnNomProd));
                _sqlCommand.Parameters.Add(new SqlParameter("@Descripcion",obproductos.lnDescripcion));
                _sqlCommand.Parameters.Add(new SqlParameter("@Color",obproductos.lnColor));
                _sqlCommand.Parameters.Add(new SqlParameter("@nopcion", opcion));

           

                _sqlParameter = new SqlParameter();
                _sqlParameter.ParameterName = "@cmensaje";
                _sqlParameter.Direction = ParameterDirection.Output;
                _sqlParameter.SqlDbType = SqlDbType.VarChar;
                _sqlParameter.Size = 50;

                _sqlCommand.Parameters.Add(_sqlParameter);
                _sqlCommand.ExecuteNonQuery();


                return null;

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
