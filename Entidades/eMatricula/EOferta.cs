using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.eMatricula
{
    public class EOferta
    {

        public int IdOferta { get; set; }

        public string Nombre { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public int IdSede { get; set; }
        public string Sede { get; set; }
        public DateTime MatriculaIniciaEl { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Observacion { get; set; }

        public string LoginUsuario { get; set; }

        /// <summary>
        /// Validar campos que requieran verificarse
        /// </summary>
        /// <returns></returns>
        public bool DatosValidos()
        {
            return !Nombre.Equals("");
        }

    }
}
