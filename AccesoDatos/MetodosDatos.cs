using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using AccesoDatos.Security;

namespace AccesoDatos
{
    /// <summary>
    /// Clase con métodos para la manipulación de strings y la creación
    /// de comandos SQL para selección y ejecución de procedimientos
    /// almacenados. 
    /// </summary>
    public class MetodosDatos
    {

        /// <summary>
        /// Obtener string de conexión desde App.config con medidas de seguridad
        /// </summary>
        /// <returns>string csb de conexión a la base de datos (configuración "J-CENTEC")</returns>
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["J-CENTEC"].ConnectionString; 
        }

        /// <summary>
        /// Crea un comando Sql de selección
        /// </summary>
        /// <returns>Comando Sql</returns>
        public SqlCommand CrearComando()
        {
            string cadenaConexion = GetConnectionString();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;
        }

        /// <summary>
        /// Crea un procedimiento almacenado con su nombre y parámetros
        /// </summary>
        /// <param name="proc">Nombre del procedimiento almacenado</param>
        /// <returns>SqlCommand para ese procedimiento almacenado</returns>
        public SqlCommand CrearComandoProc(string proc)
        {
            string cadenaConexion = GetConnectionString();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(proc, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado que no retorna una tabla
        /// </summary>
        /// <param name="comando">Sentencia o SP en SQL</param>
        /// <returns>entero que indica el estado de la ejecución</returns>
        public int EjecutarComando(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERROR FOUND");
                Console.WriteLine(ex.Message);
                throw ex;
            }

            finally
            {
                comando.Connection.Close();
                comando.Connection.Dispose();
            }

        }

        /// <summary>
        /// Ejecuta una sentencia o procedimiento almacenado que retorna una tabla.
        /// </summary>
        /// <param name="comando">Sentencia o SP en SQL</param>
        /// <returns>DataTable con datos solicitados desde la BD</returns>
        public DataTable EjecutarComandoDataTable(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                Console.WriteLine("Abierta la conexion a la base de datos");
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                comando.Connection.Close();
                comando.Connection.Dispose();
            }

            return tabla;
        }

    }
}
