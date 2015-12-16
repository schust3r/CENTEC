using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Entidad para la tabla Perfil, contiene atributos que permiten
    /// transferir información entre las diferentes capas para realizar 
    /// consultas, inserciones o modificaciones.
    /// </summary>
    public class EPerfil
    {
        // Atributos de entidad
        public int IdPerfil { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int    CantidadUsuarios { set; get; }

        public string LoginUsuario { get; set; }

        /**
         * Permisos: Módulo Configuración
         */
        public bool RegistrarPerfil { set; get; }
        public bool EliminarPerfil { set; get; }
        public bool ModificarPerfil { set; get; }
        public bool VerDetallesPerfil { set; get; }

        public bool RegistrarUsuario { set; get; }
        public bool EliminarUsuario { set; get; }
        public bool ModificarUsuario { set; get; }
        public bool VerDetallesUsuario { set; get; }

        public bool VerBitacora { set; get; }

        /**
         * Permisos: Módulo Matrícula
         */
        public bool RegistrarOferta { set; get; }
        public bool EliminarOferta { set; get; }
        public bool ModificarOferta { set; get; }
        public bool VerDetallesOferta { set; get; }
        public bool CambiarEstadoOferta { set; get; }

        public bool RegistrarCurso { set; get; }
        public bool EliminarCurso { set; get; }
        public bool ModificarCurso { set; get; }
        public bool VerDetallesCurso { set; get; }
        public bool CambiarEstadoCurso { set; get; }

        public bool MatriculaPres { get; set; }

        public bool CambiarEstadoPart { get; set; }
        public bool ImprimirComprobante { get; set; }

        /// <summary>
        /// Valida si el nombre y la descripción no son vacíos
        /// </summary>
        /// <returns>true - si los datos son correctos</returns>
        public bool ValidarDatos()
        {
            if (this.Nombre.Equals(""))
            {
                return false;
            }

            if (this.Descripcion.Equals(""))
            {
                return false;
            }

            return true;
        }

    }
}
