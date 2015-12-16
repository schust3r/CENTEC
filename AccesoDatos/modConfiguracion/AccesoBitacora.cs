using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos.modConfiguracion
{
    /// <summary>
    /// Acceso a Datos para la Bitácora de CENTEC. Permite consultar
    /// entradas existentes o registrar una nueva entrada por acción.
    /// </summary>
    public class AccesoBitacora : MetodosDatos
    {

        // Consultar bitácora
        public DataTable ConsultarBitacora(EBitacora entrada)
        {
            SqlCommand comando = CrearComandoProc("CON_BitacoraConsultar");
            comando.Parameters.AddWithValue("@FechaInicio", entrada.FechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", entrada.FechaFin);
            comando.Parameters.AddWithValue("@Usuario", entrada.LoginUsuario);
            comando.Parameters.AddWithValue("@Accion", entrada.Accion);
            comando.Parameters.AddWithValue("@TipoEvento", entrada.TipoEvento);
            comando.Parameters.AddWithValue("@Descripcion", entrada.Descripcion);
            return EjecutarComandoDataTable(comando);
        }

        // Registrar entrada en la bitácora
        public int RegistrarBitacora(EBitacora entrada)
        {
            SqlCommand comando = CrearComandoProc("CON_BitacoraRegistrar");
            comando.Parameters.AddWithValue("@Usuario", entrada.LoginUsuario);
            comando.Parameters.AddWithValue("@Accion", entrada.Accion);
            comando.Parameters.AddWithValue("@TipoEvento", entrada.TipoEvento);
            comando.Parameters.AddWithValue("@Descripcion", entrada.Descripcion);
            comando.Parameters.AddWithValue("@Entidad", entrada.Entidad);
            return EjecutarComando(comando);
        }

    }
}
