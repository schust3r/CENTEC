using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades.eMatricula
{
    public class ECurso
    {
        public string LoginUsuario { get; set; }

        public int IdOferta { get; set; }
        public string NombreOferta { get; set; }
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public int IdTipo { get; set; }
        public string NombreTipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int IdSede { get; set; }
        public string NombreSede { get; set; }
        public string Facilitador { get; set; }
        public string PoblacionMeta { get; set; }
        public string Horario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public int NumeroGrupo { get; set; }
        public string CursoRequisitoDe { get; set; }
        public string Observaciones { get; set; }
        public int Total { get; set; }

        public bool MatriculaPresencial { get; set; }
        public bool MatriculaTelefonica { get; set; }
        public bool MatriculaEnLinea { get; set; }
        public bool ListaDeEspera { get; set; }

        public int CantidadPresTel { get; set; }
        public int CantidadEnLinea { get; set; }

        /// <summary>
        /// Verificar si los datos son correctos
        /// </summary>
        /// <returns></returns>
        public bool DatosValidos()
        {
            Regex regNombre = new Regex("^[\\p{L} .'-]+$");
            Regex regCodigo = new Regex(@"^([A-Za-z0-9\s]*)$");
            if (regNombre.IsMatch(Nombre) &&
                regCodigo.IsMatch(Codigo) &&
                regCodigo.IsMatch(PoblacionMeta) &&
                regNombre.IsMatch(Facilitador))
            {
                return true;
            }
            return false;
        }


    }
}
