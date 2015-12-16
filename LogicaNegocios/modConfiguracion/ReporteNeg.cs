using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.modConfiguracion;
using System.Data;
using Entidades;

namespace LogicaNegocios.modConfiguracion
{
    /// <summary>
    /// Lógica de negocios para la sección Reporte del módulo Configuración
    /// </summary>
    public class ReporteNeg
    {

        // Acceso a la bitácora
        private AccesoBitacora reporteDAL;

        public ReporteNeg()
        {
            reporteDAL = new AccesoBitacora();
        }

        /// <summary>
        /// Obtener DataView de Bitácora a partir de DataTable
        /// </summary>
        /// <param name="entrada">Consulta con parámetros buscados por el usuario</param>
        /// <returns>IEnumerable donde cada elemento es una fila de la tabla retornada</returns>
        public DataView ConsultarBitacora(EBitacora entrada)
        {
            DataTable tabla = reporteDAL.ConsultarBitacora(entrada);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Crear un registro en bitácora a partir de una entrada válida
        /// </summary>
        /// <param name="entrada">Entidad Bitácora con información para 
        /// nueva entrada</param>
        /// <returns>true - en caso de éxito tras el registro</returns>
        public bool RegistrarBitacora(EBitacora entrada)
        {
            try
            {
                if (reporteDAL.RegistrarBitacora(entrada) != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }


    }
}
