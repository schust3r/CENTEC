using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Entidad para la tabla Bitácora, contiene atributos que permiten
    /// transferir información entre las diferentes capas para realizar 
    /// consultas, inserciones o modificaciones.
    /// </summary>
    public class EBitacora
    {
        
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime Fecha { get; set; }

        public string LoginUsuario { get; set; }
        public string Entidad { get; set; }
        public string Accion { get; set; }
        public string TipoEvento { get; set; }
        public string Descripcion { get; set; }

        /// <summary>
        /// Verifica que el nombre de login de usuario cumpla con las expresiones
        /// regulares establecidas
        /// </summary>
        /// <returns>true - si el login cumple con el formato correcto</returns>
        public bool ValidarLoginUsuario()
        {
            if (!Regex.IsMatch(this.LoginUsuario, @"^[a-zA-ZÑñ\s]+$"))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Verificar que las fechas ingresadas por el usuario tengan sentido cronológico
        /// </summary>
        /// <returns>true - si las fechas de inicio y fin han pasado las validaciones</returns>
        public bool FechaInicioFinValida()
        {
            if (FechaInicio != null && FechaFin != null)
            {
                if (FechaInicio <= DateTime.Today &&
                    FechaFin    <= DateTime.Today.AddDays(1))
                {
                    if (FechaInicio <= FechaFin)
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }

    }
}
