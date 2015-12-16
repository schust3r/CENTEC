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
    public class AccesoOfertas : MetodosDatos
    {

        /// <summary>
        /// Consultar Ofertas disponibles a partir de criterios como la sede, el
        /// estado y el nombre de la oferta registrada.
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable ConsultarOfertas(EOferta oferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaConsultar");
            comando.Parameters.AddWithValue("@IdEstado", oferta.IdEstado);
            comando.Parameters.AddWithValue("@IdSede", oferta.IdSede);
            comando.Parameters.AddWithValue("@Nombre", oferta.Nombre);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Retorna el historial de cambio de estados de una oferta dada
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable CargarHistorialOferta(int idOferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaCargarHistorial");
            comando.Parameters.AddWithValue("@IdOferta", idOferta);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Cargar una oferta específica
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable CargarOferta(int idOferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaCargar");
            comando.Parameters.AddWithValue("@IdOferta", idOferta);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Registrar una nueva oferta en la base de datos
        /// </summary>
        /// <param name="oferta">Entidad de oferta</param>
        /// <returns>1 - si la operación finalizó sin excepciones</returns>
        public int RegistrarOferta(EOferta oferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaRegistrar");
            comando.Parameters.AddWithValue("@IdEstadoOferta", oferta.IdEstado);
            comando.Parameters.AddWithValue("@IdSede", oferta.IdSede);
            comando.Parameters.AddWithValue("@Nombre", oferta.Nombre);
            comando.Parameters.AddWithValue("@FechaInicio", oferta.MatriculaIniciaEl);
            comando.Parameters.AddWithValue("@FechaRegistro", oferta.FechaRegistro);
            comando.Parameters.AddWithValue("@UltimaModificacion", oferta.UltimaModificacion);
            comando.Parameters.AddWithValue("@Observacion", oferta.Observacion);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Modificar una oferta de la base de datos
        /// </summary>
        /// <param name="oferta">Entidad de oferta</param>
        /// <returns>1 - si la operación finalizó sin excepciones</returns>
        public int ModificarOferta(EOferta oferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaModificar");
            comando.Parameters.AddWithValue("@IdOferta", oferta.IdOferta);
            comando.Parameters.AddWithValue("@IdEstadoOferta", oferta.IdEstado);
            comando.Parameters.AddWithValue("@IdSede", oferta.IdSede);
            comando.Parameters.AddWithValue("@Nombre", oferta.Nombre);
            comando.Parameters.AddWithValue("@FechaInicio", oferta.MatriculaIniciaEl);
            comando.Parameters.AddWithValue("@UltimaModificacion", oferta.UltimaModificacion);
            comando.Parameters.AddWithValue("@Observacion", oferta.Observacion);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Cambiar el estado de la oferta
        /// </summary>
        /// <param name="oferta">Entidad de oferta</param>
        /// <returns>1 - si la operación finalizó sin excepciones</returns>
        public int CambiarEstadoOferta(EOferta oferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaCambiarEstado");
            comando.Parameters.AddWithValue("@IdOferta", oferta.IdOferta);
            comando.Parameters.AddWithValue("@IdEstadoOferta", oferta.IdEstado);
            comando.Parameters.AddWithValue("@LoginUsuario", oferta.LoginUsuario);
            comando.Parameters.AddWithValue("@Observaciones", oferta.Observacion);
            comando.Parameters.AddWithValue("@FechaHora", oferta.FechaRegistro);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Eliminar una oferta existente de la base de datos
        /// </summary>
        /// <param name="oferta">Entidad de oferta</param>
        /// <returns>1 - si la operación finalizó sin excepciones</returns>
        public int EliminarOferta(int idOferta)
        {
            SqlCommand comando = CrearComandoProc("MAT_OfertaEliminar");
            comando.Parameters.AddWithValue("@IdOferta", idOferta);
            return EjecutarComando(comando);
        }

        // Cargar la lista de estados para una oferta
        public DataTable CargarListaEstados()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaEstadosOferta");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar distintas sedes a las que puede pertenecer una oferta
        public DataTable CargarListaSedes()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaSedes");
            return EjecutarComandoDataTable(comando);
        }

    }
}
