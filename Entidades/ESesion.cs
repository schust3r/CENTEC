using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Collections;

namespace Presentacion
{
    /// <summary>
    /// Entidad para la sesión de usuario contiene atributos que permiten
    /// transferir información entre las diferentes capas para realizar 
    /// consultas, inserciones o modificaciones.
    /// </summary>
    public class ESesion
    {
        // Datos del usuario en sesión actual
        public string Sede { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string NombrePerfil { get; set; }
        public int IdSede { get; set; }

        // Permisos: Módulo Configuración
        public EPerfil permisos;

        public ESesion()
        {
            permisos = new EPerfil();
        }

        /// <summary>
        /// Cargar el Login, nombre completo y nombre de perfil asignado a un usuario.
        /// Se cargan los permisos asociados a los módulos para determinar el nivel de
        /// acceso del usuario.
        /// </summary>
        /// <param name="userData">ArrayList con los datos string del usuario</param>
        /// <param name="permConf">ArrayList con los permisos del usuario en Configuración</param>
        public void DefinirSesion(List<string> userData, DataRow permConf)
        {
            Sede = userData[0];
            Login = userData[1];
            NombrePerfil = userData[2];
            Nombre = userData[3];
            IdSede = Convert.ToInt16(userData[5]);

            // Permisos asociados al módulo 'Configuración'

            permisos.RegistrarPerfil = ToBool(permConf["Registrar perfil"].ToString());
            permisos.EliminarPerfil = ToBool(permConf["Eliminar perfil"].ToString());
            permisos.ModificarPerfil = ToBool(permConf["Modificar perfil"].ToString());
            permisos.VerDetallesPerfil = ToBool(permConf["Ver detalle de perfil"].ToString());

            permisos.RegistrarUsuario = ToBool(permConf["Registrar usuario"].ToString());
            permisos.EliminarUsuario = ToBool(permConf["Eliminar usuario"].ToString());
            permisos.ModificarUsuario = ToBool(permConf["Modificar usuario"].ToString());
            permisos.VerDetallesUsuario = ToBool(permConf["Ver detalle de usuario"].ToString());

            permisos.VerBitacora = ToBool(permConf["Ver bitácora"].ToString());

            permisos.RegistrarOferta = ToBool(permConf["Registrar oferta"].ToString());
            permisos.EliminarOferta = ToBool(permConf["Eliminar oferta"].ToString());
            permisos.ModificarOferta = ToBool(permConf["Modificar oferta"].ToString());
            permisos.VerDetallesOferta = ToBool(permConf["Ver detalle de oferta"].ToString());
            permisos.CambiarEstadoOferta = ToBool(permConf["Cambiar estado de oferta"].ToString());

            permisos.RegistrarCurso = ToBool(permConf["Registrar curso"].ToString());
            permisos.EliminarCurso = ToBool(permConf["Eliminar curso"].ToString());
            permisos.ModificarCurso = ToBool(permConf["Modificar curso"].ToString());
            permisos.VerDetallesCurso = ToBool(permConf["Ver detalle de curso"].ToString());
            permisos.CambiarEstadoCurso = ToBool(permConf["Cambiar estado de curso"].ToString());

            permisos.MatriculaPres = ToBool(permConf["Matrícula presencial"].ToString());

            permisos.CambiarEstadoPart = ToBool(permConf["Cambiar estado de participante"].ToString());
            permisos.ImprimirComprobante = ToBool(permConf["Imprimir comprobante"].ToString());
        }

        private bool ToBool(string obj)
        {
            return obj == "1";
        }

        // Verificación de acceso: Módulo 'CONFIGURACIÓN' //

        /// <summary>
        /// Verificar acceso a Bitácora
        /// </summary>
        /// <returns>true - si la sesión puede acceder a Bitácora</returns>
        public bool TieneAccesoABitacora()
        {
            return permisos.VerBitacora;
        }

        /// <summary>
        /// Verificar acceso a Perfil
        /// </summary>
        /// <returns>true - si la sesión puede acceder a Perfil</returns>
        public bool TieneAccesoAPerfil()
        {
            return permisos.RegistrarPerfil || 
                   permisos.EliminarPerfil || 
                   permisos.ModificarPerfil || 
                   permisos.VerDetallesPerfil;
        }

        /// <summary>
        /// Verificar acceso a Usuario
        /// </summary>
        /// <returns>true - si la sesión puede acceder a Usuario</returns>
        public bool TieneAccesoAUsuario()
        {
            return permisos.RegistrarUsuario || 
                   permisos.EliminarUsuario || 
                   permisos.ModificarUsuario || 
                   permisos.VerDetallesUsuario;
        }

        
        // Verificación de acceso: Módulo 'MATRÍCULA' //
         
        /// <summary>
        /// Verificar acceso a la oferta
        /// </summary>
        /// <returns>true - si la sesión puede acceder a Oferta</returns>
        public bool TieneAccesoAOferta()
        {
            return permisos.RegistrarOferta || permisos.EliminarOferta ||
                   permisos.ModificarOferta || permisos.VerDetallesOferta ||
                   permisos.CambiarEstadoOferta;
        }

        /// <summary>
        /// Verificar acceso a curso
        /// </summary>
        /// <returns>true - si la sesión puede acceder a Curso</returns>
        public bool TieneAccesoACurso()
        {
            return permisos.RegistrarCurso || permisos.EliminarCurso ||
                   permisos.ModificarCurso || permisos.VerDetallesCurso ||
                   permisos.CambiarEstadoCurso;
        }

        /// <summary>
        /// Verificar acceso a Matrícula Presencial
        /// </summary>
        /// <returns>true - si la sesión puede acceder a matrícula</returns>
        public bool TieneAccesoAMatricula()
        {
            return permisos.MatriculaPres;
        }

        /// <summary>
        /// Verificar acceso a Participantes
        /// </summary>
        /// <returns>true - si la sesión puede acceder a participantes</returns>
        public bool TieneAccesoAParticipante()
        {
            return permisos.CambiarEstadoPart || permisos.ImprimirComprobante;
        }
    }

}
