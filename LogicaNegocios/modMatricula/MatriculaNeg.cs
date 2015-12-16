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
    public class MatriculaNeg
    {
        // Acceso a matrícula
        private AccesoMatricula matriculaDAL;

        public MatriculaNeg()
        {
            matriculaDAL = new AccesoMatricula();
        }

        /// <summary>
        /// Consultar los cursos abiertos para la matricula
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public DataView ConsultarCursos(int idSede)
        {
            DataTable tabla = matriculaDAL.ConsultarCursos(idSede);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Consultar cursos para matrícula online
        /// </summary>
        /// <returns></returns>
        public DataView ConsultarCursosEnLinea()
        {
            DataTable tabla = matriculaDAL.ConsultarCursosEnLinea();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Reservar cupos con control de concurrencia
        /// </summary>
        /// <returns>true - si hubo éxito al reservar</returns>
        public bool ReservarCupos(EMatriculaPres res)
        {
            try
            {
                if (matriculaDAL.ReservarCupos(res) != 0)
                {
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
        /// Matricular un nuevo participante
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public bool MatricularParticipante(EParticipante part)
        {
            try
            {
                if (matriculaDAL.MatricularParticipante(part) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = part.Usuario;
                    entrada.Accion = "Registrar participante";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado el participante: " +
                                         "Curso = " + part.NombreCurso + ", " +
                                         "Identificación = " + part.Identificacion + ", " +
                                         "Nombre = " + part.Nombre + ", " +
                                         "Teléfono = " + part.Telefono + ", " +
                                         "Correo electrónico = " + part.Correo + ", " +
                                         "Observaciones = " + part.Observaciones + ", " +
                                         "Tipos de apoyo requeridos = " + part.TipoApoyo + ".";
                    entrada.Entidad = part.Nombre;
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
        /// Matricular un nuevo participante en línea
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public bool MatricularParticipanteEnLinea(EParticipante part)
        {
            try
            {
                if (matriculaDAL.MatricularParticipanteEnLinea(part) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = part.Usuario;
                    entrada.Accion = "Registrar participante";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado al participante en línea: " +
                                         "Curso = " + part.NombreCurso + ", " +
                                         "Identificación = " + part.Identificacion + ", " +
                                         "Nombre = " + part.Nombre + ", " +
                                         "Teléfono = " + part.Telefono + ", " +
                                         "Correo electrónico = " + part.Correo + ", " +
                                         "Observaciones = " + part.Observaciones + ", " +
                                         "Tipos de apoyo requeridos = " + part.TipoApoyo + ".";
                    entrada.Entidad = part.Nombre;
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
        /// Reservar cupo adicional para el curso
        /// </summary>
        /// <returns>true - si hubo éxito al reservar</returns>
        public bool ReservarCupoAdicional(string cod)
        {
            try
            {
                if (matriculaDAL.ReservarCupoAdicional(cod) != 0)
                {
                    // Notificar registro a bitácora
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
        /// Abortar el proceso de matrícula y regresar los cupos
        /// </summary>
        /// <param name="abort"></param>
        /// <returns></returns>
        public bool LiberarCuposMatricula(EMatriculaPres abort)
        {
            try
            {
                if (matriculaDAL.LiberarCuposMatricula(abort) != 0)
                {
                    // Notificar registro a bitácora
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
        /// Obtener lista de tipos de matricula
        /// </summary>
        /// <returns></returns>
        public DataView CargarListaTipos()
        {
            DataTable tabla = matriculaDAL.CargarListaTipos();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Obtener lista de tipos de identificación del participante
        /// </summary>
        /// <returns></returns>
        public DataView CargarListaTiposParticipante()
        {
            DataTable tabla = matriculaDAL.CargarListaTiposParticipante();
            return tabla.AsDataView();
        }

    }
}
