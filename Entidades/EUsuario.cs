using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Entidad para la tabla Usuario, contiene atributos que permiten
    /// transferir información entre las diferentes capas para realizar 
    /// consultas, inserciones o modificaciones.
    /// </summary>
    public class EUsuario
    {
        // Atributos de entidad
        public int IdSede { set; get; }
        public string Login { set; get; }
        public string Nombre { set; get; }
        public int IdPerfil { set; get; }
        public bool Activo { set; get; }
        public string Contrasena { set; get; }
        public string NombrePerfil { set; get; }

        public string LoginUsuario { set; get; } // Info de sesión activa

        public EUsuario()
        {
            this.Activo = false;
        }

        // Validaciones sobre campos que pueden contener algún problema
        
        /// <summary>
        /// Verificar si los datos son válidos para efectuar un registro de nuevo usuario
        /// </summary>
        /// <returns>true - si los datos son válidos</returns>
        public bool DatosValidos()
        {
            if (ValidarLogin() && ValidarContrasena() && ValidarNombre())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verificar si los datos son válidos para modificar a un usuario existente
        /// </summary>
        /// <returns>true - si los datos son válidos</returns>
        public bool DatosValidosModificacion()
        {
            if (ValidarNombre())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verificar que la contraseña no contenga caracteres extraños
        /// ni sea mayor de 32 caracteres
        /// </summary>
        /// <returns>true - si el login cumple con los requisitos</returns>
        private bool ValidarLogin()
        {
            Regex regex = new Regex(@"[a-zA-ZñÑ\s]");
            if (!regex.IsMatch(this.Login) || Login.Length > 32)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Verificar que la contraseña no sea vacía ni muy corta
        /// </summary>
        /// <returns>true - si la contraseña cumple los requisitos</returns>
        private bool ValidarContrasena()
        {
            if (Contrasena.Equals("") || Contrasena.Length < 4)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Verificar que el nombre no esté vacío
        /// </summary>
        /// <returns>true - si el nombre es válido</returns>
        private bool ValidarNombre()
        {
            return !Nombre.Equals("");
        }

    }
}
