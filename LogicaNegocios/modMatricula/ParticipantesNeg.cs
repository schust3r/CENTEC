using AccesoDatos.modMatricula;
using Entidades;
using Entidades.eMatricula;
using LogicaNegocios.modConfiguracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios.modMatricula
{
    public class ParticipantesNeg
    {
        // Acceso a participantes
        private AccesoParticipantes partDAL;

        public ParticipantesNeg()
        {
            partDAL = new AccesoParticipantes();
        }

        /// <summary>
        /// Consultar tabla de participantes
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView ConsultarParticipantes(EParticipante consulta)
        {
            DataTable tabla = partDAL.ConsultarParticipantes(consulta);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar lista de ofertas
        /// </summary>
        /// <returns></returns>
        public DataView CargarListaOfertas()
        {
            DataTable tabla = partDAL.CargarListaOfertas();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cambiar estado del participante
        /// </summary>
        /// <param name="curso"></param>
        /// <param name="anterior"></param>
        /// <param name="nuevo"></param>
        /// <returns></returns>
        public bool CambiarEstadoParticipante(EParticipante part, string anterior, string nuevo)
        {
            try
            {
                if (anterior.Equals("Matriculado") && nuevo.Equals("Desmatriculado") ||
                    anterior.Equals("Matriculado") && nuevo.Equals("Desertado") ||
                    anterior.Equals("Matriculado") && nuevo.Equals("En espera") ||
                    anterior.Equals("En espera") && nuevo.Equals("Por confirmar") ||
                    anterior.Equals("Por confirmar") && nuevo.Equals("No confirmado") ||
                    anterior.Equals("Por confirmar") && nuevo.Equals("Matriculado"))
                {
                    if (partDAL.CambiarEstadoParticipante(part) != 0)
                    {
                        // Notificar a bitácora
                        EBitacora entrada = new EBitacora();
                        entrada.LoginUsuario = part.LoginUsuario;
                        entrada.Accion = "Cambiar estado de participante";
                        entrada.TipoEvento = "Modificar";
                        entrada.Descripcion = "El estado del participante '" + part.Identificacion +
                                              "' fue cambiado de '" + anterior + "' a '" +
                                               nuevo + "'.";
                        entrada.Entidad = part.Identificacion;
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
        /// Cargar lista de estados
        /// </summary>
        /// <returns></returns>
        public DataView CargarListaEstados()
        {
            DataTable tabla = partDAL.CargarListaEstados();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar el historial de cambios de estado del participante
        /// </summary>
        /// <param name="idOferta"></param>
        /// <returns></returns>
        public DataView CargarHistorialParticipante(int idPart)
        {
            DataTable tabla = partDAL.CargarHistorialParticipante(idPart);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar lista de tipos
        /// </summary>
        /// <returns></returns>
        public DataView CargarListaTipos()
        {
            DataTable tabla = partDAL.CargarListaTipos();
            return tabla.AsDataView();
        }

    }
}
