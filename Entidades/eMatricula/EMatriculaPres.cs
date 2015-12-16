using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.eMatricula
{
    public class EMatriculaPres
    {

        public int IdSede { get; set; }

        public string Codigo { get; set; }
        public string NombreCurso { get; set; }
        public int IdTipoMatricula { get; set; }
        public int Cupos { get; set; }
        public bool AceptaEspera { get; set; }

    }
}
