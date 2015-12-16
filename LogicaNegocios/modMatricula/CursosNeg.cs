using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.modMatricula;
using System.Data;
using Entidades.eMatricula;
using Entidades;
using LogicaNegocios.modConfiguracion;

namespace LogicaNegocios.modMatricula
{
    public class CursosNeg
    {
        // Acceso a cursos
        private AccesoCursos cursosDAL;

        public CursosNeg()
        {
            cursosDAL = new AccesoCursos();
        }

        /// <summary>
        /// Consultar tabla de cursos
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView ConsultarCursos(ECurso consulta)
        {
            DataTable tabla = cursosDAL.ConsultarCursos(consulta);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar una tupla de la base de datos (curso específico)
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataRow CargarCurso(string cod)
        {
            DataTable tabla = cursosDAL.CargarCurso(cod);
            return tabla.Rows[0];
        }

        /// <summary>
        /// Registrar curso
        /// </summary>
        /// <param name="curso"></param>
        /// <returns></returns>
        public bool RegistrarCurso(ECurso curso)
        {
            try
            {
                if (cursosDAL.RegistrarCurso(curso) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = curso.LoginUsuario;
                    entrada.Accion = "Registrar curso";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado el curso '" + curso.Nombre +
                                         "' con la siguiente información: " +
                                         "Oferta = " + curso.NombreOferta + ", " +
                                         "Estado = " + curso.NombreEstado + ", " +
                                         "Código = " + curso.Codigo + ", " +
                                         "Tipo = " + curso.NombreTipo + ", " +
                                         "Sede = " + curso.NombreSede + ", " +
                                         "Facilitador = " + curso.Facilitador + ", " +
                                         "Población meta = " + curso.PoblacionMeta + ", " +
                                         "Horario = " + curso.Horario + ", " +
                                         "Número de grupo = " + curso.NumeroGrupo + ", " +
                                         "Lista de espera = " + GetSiNo(curso.ListaDeEspera) + ", " +
                                         "Curso requisito de = " + curso.CursoRequisitoDe + ", " +
                                         "Requisitos y observaciones = " + curso.Observaciones + ", " +
                                         "Total = " + curso.Total.ToString() + ", " +
                                         "Matrícula presencial = " + GetSiNo(curso.MatriculaPresencial) + ", " +
                                         "Matrícula telefónica = " + GetSiNo(curso.MatriculaTelefonica) + ", " +
                                         "Cantidad presencial y telefónica = " + curso.CantidadPresTel.ToString() + ", " +
                                         "Matrícula en línea = " + GetSiNo(curso.MatriculaEnLinea) + ", " +
                                         "Cantidad en línea = " + curso.CantidadEnLinea + ".";
                    entrada.Entidad = curso.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private string GetSiNo(bool val)
        {
            if (val) { return "Sí"; }
            else return "No";
        }

        /// <summary>
        /// Modificar un curso existente
        /// </summary>
        /// <param name="curso"></param>
        /// <returns></returns>
        public bool ModificarCurso(ECurso curso)
        {
            try
            {
                if (cursosDAL.ModificarCurso(curso) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = curso.LoginUsuario;
                    entrada.Accion = "Modificar curso";
                    entrada.TipoEvento = "Modificar";
                    entrada.Descripcion = "Se ha modificado el curso '" + curso.Codigo +
                                         "' con la siguiente información: " +
                                         "Oferta = " + curso.NombreOferta + ", " +
                                         "Estado = " + curso.NombreEstado + ", " +
                                         "Código = " + curso.Codigo + ", " +
                                         "Tipo = " + curso.NombreTipo + ", " +
                                         "Sede = " + curso.NombreSede + ", " +
                                         "Facilitador = " + curso.Facilitador + ", " +
                                         "Población meta = " + curso.PoblacionMeta + ", " +
                                         "Horario = " + curso.Horario + ", " +
                                         "Número de grupo = " + curso.NumeroGrupo + ", " +
                                         "Lista de espera = " + GetSiNo(curso.ListaDeEspera) + ", " +
                                         "Curso requisito de = " + curso.CursoRequisitoDe + ", " +
                                         "Requisitos y observaciones = " + curso.Observaciones + ", " +
                                         "Total = " + curso.Total.ToString() + ", " +
                                         "Matrícula presencial = " + GetSiNo(curso.MatriculaPresencial) + ", " +
                                         "Matrícula telefónica = " + GetSiNo(curso.MatriculaTelefonica) + ", " +
                                         "Cantidad presencial y telefónica = " + curso.CantidadPresTel.ToString() + ", " +
                                         "Matrícula en línea = " + GetSiNo(curso.MatriculaEnLinea) + ", " +
                                         "Cantidad en línea = " + curso.CantidadEnLinea + ".";
                    entrada.Entidad = curso.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Eliminar un curso seleccionado desde la tabla
        /// </summary>
        /// <param name="curso"></param>
        /// <returns></returns>
        public bool EliminarCurso(ECurso curso)
        {
            try
            {
                if (cursosDAL.EliminarCurso(curso.Codigo) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = curso.LoginUsuario;
                    entrada.Accion = "Eliminar curso";
                    entrada.TipoEvento = "Eliminar";
                    entrada.Descripcion = "Se ha eliminado la información del curso '" +
                                           curso.Nombre + "'.";
                    entrada.Entidad = curso.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cambia el estado de la curso y actualiza el historial + validaciones
        /// </summary>
        /// <param name="curso"></param>
        /// <returns>true - si el procedimiento tuvo éxito</returns>
        public bool CambiarEstadoCurso(ECurso curso, string anterior, string nuevo)
        {
            try
            {
                if (anterior.Equals("Planificado") && nuevo.Equals("Abierto") ||
                    anterior.Equals("Curso en pausa") && nuevo.Equals("Abierto") ||
                    anterior.Equals("Matrícula incompleta") && nuevo.Equals("Abierto") ||
                    anterior.Equals("Abierto") && !nuevo.Equals("Abierto"))
                {
                    if (cursosDAL.CambiarEstadoCurso(curso) != 0)
                    {
                        // Notificar a bitácora
                        EBitacora entrada = new EBitacora();
                        entrada.LoginUsuario = curso.LoginUsuario;
                        entrada.Accion = "Cambiar estado de curso";
                        entrada.TipoEvento = "Modificar";
                        entrada.Descripcion = "El estado del curso '" + curso.Nombre + 
                                              "' fue cambiado de '" + anterior + "' a '" +
                                               nuevo + "'.";
                        entrada.Entidad = curso.Nombre;
                        new ReporteNeg().RegistrarBitacora(entrada);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Consultar tabla de cursos
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public int ObtenerCantidadCursos()
        {
            DataTable tabla = cursosDAL.ObtenerCantidadCursos();
            return Convert.ToInt16(tabla.Rows[0][0]);
        }

        /// <summary>
        /// Cargar historial de cambios de estado
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataView CargarHistorialCurso(string cod)
        {
            DataTable tabla = cursosDAL.CargarHistorialCurso(cod);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar listado de cursos para cursos
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaOfertas()
        {
            DataTable tabla = cursosDAL.CargarListaOfertas();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar listado de tipos de curso (público o privado)
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaTipos()
        {
            DataTable tabla = cursosDAL.CargarListaTipos();
            return tabla.AsDataView();
        }


        /// <summary>
        /// Cargar listado de estados para cursos
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaEstados()
        {
            DataTable tabla = cursosDAL.CargarListaEstados();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar listado de sedes para cursos
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaSedes()
        {
            DataTable tabla = cursosDAL.CargarListaSedes();
            return tabla.AsDataView();
        }

    }
}
