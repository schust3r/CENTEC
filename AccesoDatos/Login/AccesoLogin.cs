using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Login
{
    /// <summary>
    /// Acceso a Datos para acceder al sistema CENTEC. Permite verificar
    /// la existencia de un usuario con ciertos credenciales.
    /// </summary>
    public class AccesoLogin : MetodosDatos
    {

        // Recuperar tuplas que coincidan con un login y pass definidos
        public DataTable VerificarUsuario(string login, string pass)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioVerificar");
            comando.Parameters.AddWithValue("@Login", login);
            comando.Parameters.AddWithValue("@Pass", pass);
            return EjecutarComandoDataTable(comando);
        }

    }
}
