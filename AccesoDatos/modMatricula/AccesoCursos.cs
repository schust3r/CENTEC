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
    public class AccesoCursos : MetodosDatos
    {

        /// <summary>
        /// Consultar Cursos disponibles a partir de criterios
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable ConsultarCursos(ECurso curso)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoConsultar");
            comando.Parameters.AddWithValue("@Nombre", curso.Nombre);
            comando.Parameters.AddWithValue("@IdEstado", curso.IdEstado);
            comando.Parameters.AddWithValue("@IdOferta", curso.IdOferta);
            comando.Parameters.AddWithValue("@IdTipo", curso.IdTipo);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Carga un curso específico a partir de su código
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable CargarCurso(string cod)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoCargar");
            comando.Parameters.AddWithValue("@Codigo", cod);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Cambiar el estado del curso
        /// </summary>
        /// <param name="curso">Entidad de Curso</param>
        /// <returns>1 - si la operación finalizó sin excepciones</returns>
        public int CambiarEstadoCurso(ECurso curso)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoCambiarEstado");
            comando.Parameters.AddWithValue("@Codigo", curso.Codigo);
            comando.Parameters.AddWithValue("@IdEstadoCurso", curso.IdEstado);
            comando.Parameters.AddWithValue("@LoginUsuario", curso.LoginUsuario);
            comando.Parameters.AddWithValue("@Observaciones", curso.Observaciones);
            comando.Parameters.AddWithValue("@FechaHora", curso.FechaRegistro);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Cargar historial del curso
        /// </summary>
        /// <param name="cod"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable CargarHistorialCurso(string cod)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoCargarHistorial");
            comando.Parameters.AddWithValue("@Codigo", cod);
            return EjecutarComandoDataTable(comando);
        }

        /// <summary>
        /// Registrar un nuevo curso con la información registrada por el usuario
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>int que indica el status de la consulta</returns>
        public int RegistrarCurso(ECurso curso)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoRegistrar");
            comando.Parameters.AddWithValue("@Codigo", curso.Codigo);
            comando.Parameters.AddWithValue("@IdOferta", curso.IdOferta);
            comando.Parameters.AddWithValue("@IdEstadoCurso", curso.IdEstado);
            comando.Parameters.AddWithValue("@IdTipo", curso.IdTipo);
            comando.Parameters.AddWithValue("@Nombre", curso.Nombre);
            comando.Parameters.AddWithValue("@IdSede", curso.IdSede);
            comando.Parameters.AddWithValue("@Facilitador", curso.Facilitador);
            comando.Parameters.AddWithValue("@Horario", curso.Horario);
            comando.Parameters.AddWithValue("@PoblacionMeta", curso.PoblacionMeta);
            comando.Parameters.AddWithValue("@FechaRegistro", curso.FechaRegistro);
            comando.Parameters.AddWithValue("@UltModificacion", curso.UltimaModificacion);
            comando.Parameters.AddWithValue("@NumeroGrupo", curso.NumeroGrupo);
            comando.Parameters.AddWithValue("@CursoRequisitoDe", curso.CursoRequisitoDe);
            comando.Parameters.AddWithValue("@Observaciones", curso.Observaciones);
            comando.Parameters.AddWithValue("@MatriculaPresencial", curso.MatriculaPresencial);
            comando.Parameters.AddWithValue("@MatriculaTelefonica", curso.MatriculaTelefonica);
            comando.Parameters.AddWithValue("@CantidadPresencialTelefonica", curso.CantidadPresTel);
            comando.Parameters.AddWithValue("@MatriculaEnLinea", curso.MatriculaEnLinea);
            comando.Parameters.AddWithValue("@CantidadEnLinea", curso.CantidadEnLinea);
            comando.Parameters.AddWithValue("@ListaEspera", curso.ListaDeEspera);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Eliminar un curso seleccionado
        /// </summary>
        /// <param name="codigo">Codigo del curso a eliminar</param>
        /// <returns></returns>
        public int EliminarCurso(string codigo)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoEliminar");
            comando.Parameters.AddWithValue("@Codigo", codigo);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Modificar un curso existente
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>int que indica el status de la consulta</returns>
        public int ModificarCurso(ECurso curso)
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoModificar");
            comando.Parameters.AddWithValue("@Codigo", curso.Codigo);
            comando.Parameters.AddWithValue("@IdOferta", curso.IdOferta);
            comando.Parameters.AddWithValue("@IdTipo", curso.IdTipo);
            comando.Parameters.AddWithValue("@Nombre", curso.Nombre);
            comando.Parameters.AddWithValue("@IdSede", curso.IdSede);
            comando.Parameters.AddWithValue("@Facilitador", curso.Facilitador);
            comando.Parameters.AddWithValue("@Horario", curso.Horario);
            comando.Parameters.AddWithValue("@PoblacionMeta", curso.PoblacionMeta);
            comando.Parameters.AddWithValue("@UltModificacion", curso.UltimaModificacion);
            comando.Parameters.AddWithValue("@CursoRequisitoDe", curso.CursoRequisitoDe);
            comando.Parameters.AddWithValue("@Observaciones", curso.Observaciones);
            comando.Parameters.AddWithValue("@MatriculaPresencial", curso.MatriculaPresencial);
            comando.Parameters.AddWithValue("@MatriculaTelefonica", curso.MatriculaTelefonica);
            comando.Parameters.AddWithValue("@CantidadPresencialTelefonica", curso.CantidadPresTel);
            comando.Parameters.AddWithValue("@MatriculaEnLinea", curso.MatriculaEnLinea);
            comando.Parameters.AddWithValue("@CantidadEnLinea", curso.CantidadEnLinea);
            comando.Parameters.AddWithValue("@ListaEspera", curso.ListaDeEspera);
            return EjecutarComando(comando);
        }

        /// <summary>
        /// Obtener cantidad de cursos registrados
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>datatable con las coincidencias</returns>
        public DataTable ObtenerCantidadCursos()
        {
            SqlCommand comando = CrearComandoProc("MAT_CursoObtenerCantidad");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar la lista de estados para un curso
        public DataTable CargarListaOfertas()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaOfertas");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar la lista de tipos (público, privado) para un curso
        public DataTable CargarListaTipos()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaTiposCurso");
            return EjecutarComandoDataTable(comando);
        }


        // Cargar la lista de estados para un curso
        public DataTable CargarListaEstados()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaEstadosCurso");
            return EjecutarComandoDataTable(comando);
        }

        // Cargar distintas sedes a las que puede pertenecer un curso
        public DataTable CargarListaSedes()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaSedes");
            return EjecutarComandoDataTable(comando);
        }


    }
}
