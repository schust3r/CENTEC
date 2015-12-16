using Entidades.eMatricula;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.modMatricula
{
    public class AccesoParticipantes : MetodosDatos
    {

        /// <summary>
        /// Consultar participante a partir del tipo, usuario, estado, 
        /// oferta e identificación
        /// </summary>
        /// <param name="part"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable ConsultarParticipantes(EParticipante part)
        {
            SqlCommand comando = CrearComandoProc("MAT_ParticipanteConsultar");
            comando.Parameters.AddWithValue("@Usuario", part.Usuario);
            comando.Parameters.AddWithValue("@IdEstado", part.IdEstado);
            comando.Parameters.AddWithValue("@IdOferta", part.IdOferta);
            comando.Parameters.AddWithValue("@IdTipo", part.IdTipoMatricula);
            comando.Parameters.AddWithValue("@Identificacion", part.Identificacion);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Registrar cambio en estado del participante
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public int CambiarEstadoParticipante(EParticipante part)
        {
            SqlCommand comando = CrearComandoProc("MAT_ParticipanteCambiarEstado");
            comando.Parameters.AddWithValue("@IdParticipante", part.IdParticipante);
            comando.Parameters.AddWithValue("@IdEstado", part.IdEstado);
            comando.Parameters.AddWithValue("@LoginUsuario", part.LoginUsuario);
            comando.Parameters.AddWithValue("@Observaciones", part.Observaciones);
            comando.Parameters.AddWithValue("@FechaHora", part.FechaMatricula);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Cargar tabla con cambios en historial del participante
        /// </summary>
        /// <param name="idPart"></param>
        /// <returns></returns>
        public DataTable CargarHistorialParticipante(int idPart)
        {
            SqlCommand comando = CrearComandoProc("MAT_ParticipanteCargarHistorial");
            comando.Parameters.AddWithValue("@IdParticipante", idPart);
            return EjecutarComandoDataTable(comando);
        }

        // Cargar la lista de estados para un participante
        public DataTable CargarListaEstados()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaEstadosParticipante");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar distintas sedes a las que puede pertenecer una part
        public DataTable CargarListaOfertas()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaOfertas");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar la lista de estados para un participante
        public DataTable CargarListaTipos()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaTiposParticipante");
            return EjecutarComandoDataTable(comando);
        }

    }
}
