using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.eMatricula
{
    public class EParticipante
    {

        public string Usuario { get; set; }

        public int IdParticipante { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
        public string NombreCurso { get; set; }
        public int IdTipoMatricula { get; set; }
        public int IdTipoId { get; set; }
        public DateTime FechaMatricula { get; set; }
        public int Orden { get; set; }
        public bool ListaEspera { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }
        public string TipoApoyo { get; set; }

        public int IdOferta { get; set; }

        // Guardar el login de la persona que actuó (actor)
        public string LoginUsuario { get; set; }

        public bool DatosValidos()
        {
            bool valido =  !(string.IsNullOrWhiteSpace(Identificacion) &&
                             string.IsNullOrWhiteSpace(Nombre) &&
                             string.IsNullOrWhiteSpace(Apellidos) &&
                             string.IsNullOrWhiteSpace(Correo));
           return valido;
        }

    }
}
