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
    public class AccesoMatricula : MetodosDatos
    {

        /// <summary>
        /// Consultar matPresicipante a matPresir del tipo, usuario, estado, 
        /// oferta e identificación
        /// </summary>
        /// <param name="matPres"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable ConsultarCursos(int idSede)
        {
            SqlCommand comando = CrearComandoProc("MAT_PresencialCursos");
            comando.Parameters.AddWithValue("@IdSede", idSede);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Consultar cursos disponibles para matricula en línea
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultarCursosEnLinea()
        {
            SqlCommand comando = CrearComandoProc("MAT_EnLineaCursos");
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Cargar lista de tipos de matrícula
        /// </summary>
        /// <returns></returns>
        public DataTable CargarListaTipos()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaTiposMat");
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Cargar los tipos de identificacion del participante
        /// </summary>
        /// <returns></returns>
        public DataTable CargarListaTiposParticipante()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaTiposIdParticipante");
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Reservar cupos si no hay error de concurrencia en la base de 
        /// datos 
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public int ReservarCupos(EMatriculaPres res)
        {
            SqlCommand comando = CrearComandoProc("MAT_PresencialReservar");
            comando.Parameters.AddWithValue("@Codigo", res.Codigo);
            comando.Parameters.AddWithValue("@Cupos", res.Cupos);
            var returnParameter = comando.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            EjecutarComando(comando);
            return Convert.ToInt16(returnParameter.Value);
        }

        /// <summary>
        /// Matricular participante en línea validando que el estado
        /// de ofertas, cursos y cupos sea correcto.
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public int MatricularParticipanteEnLinea(EParticipante part)
        {
            SqlCommand comando = CrearComandoProc("MAT_EnLineaRegistrar");
            comando.Parameters.AddWithValue("@Codigo", part.Codigo);
            comando.Parameters.AddWithValue("@IdTipoId", part.IdTipoId);
            comando.Parameters.AddWithValue("@Identificacion", part.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", part.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", part.Apellidos);
            comando.Parameters.AddWithValue("@Correo", part.Correo);
            comando.Parameters.AddWithValue("@Telefono", part.Telefono);
            comando.Parameters.AddWithValue("@Observaciones", part.Observaciones);
            comando.Parameters.AddWithValue("@TipoApoyo", part.TipoApoyo);
            var returnParameter = comando.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            EjecutarComando(comando);
            return Convert.ToInt16(returnParameter.Value);
        }

        /// <summary>
        /// Reservar un cupo adicional
        /// </summary>
        /// <param ="codigo"></param>
        /// <returns></returns>
        public int ReservarCupoAdicional(string codigo)
        {
            SqlCommand comando = CrearComandoProc("MAT_PresencialReservarAdicional");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            var returnParameter = comando.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            EjecutarComando(comando);
            return Convert.ToInt16(returnParameter.Value);
        }

        /// <summary>
        /// Salir del proceso de matrícula y devolver los cupos
        /// </summary>
        /// <param name="abort"></param>
        /// <returns></returns>
        public int LiberarCuposMatricula(EMatriculaPres abort)
        {
            SqlCommand comando = CrearComandoProc("MAT_PresencialLiberarCupos");
            comando.Parameters.AddWithValue("@Codigo", abort.Codigo);
            comando.Parameters.AddWithValue("@Cupos", abort.Cupos);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Matricular a un participante
        /// </summary>
        /// <param name="part">Entidad Participante</param>
        /// <returns></returns>
        public int MatricularParticipante(EParticipante part)
        {
            SqlCommand comando = CrearComandoProc("MAT_ParticipanteRegistrar");
            comando.Parameters.AddWithValue("@Login", part.Usuario);
            comando.Parameters.AddWithValue("@Estado", part.Estado);
            comando.Parameters.AddWithValue("@Codigo", part.Codigo);
            comando.Parameters.AddWithValue("@IdTipoMatricula", part.IdTipoMatricula);
            comando.Parameters.AddWithValue("@FechaMatricula", part.FechaMatricula);
            comando.Parameters.AddWithValue("@Orden", part.Orden);
            comando.Parameters.AddWithValue("@ListaEspera", part.ListaEspera);
            comando.Parameters.AddWithValue("@IdTipoId", part.IdTipoId);
            comando.Parameters.AddWithValue("@Identificacion", part.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", part.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", part.Apellidos);
            comando.Parameters.AddWithValue("@Correo", part.Correo);
            comando.Parameters.AddWithValue("@Telefono", part.Telefono);
            comando.Parameters.AddWithValue("@Observaciones", part.Observaciones);
            comando.Parameters.AddWithValue("@TipoApoyo", part.TipoApoyo);
            return EjecutarComando(comando);
        }


    }
}
